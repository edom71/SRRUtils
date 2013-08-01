using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using ProtoBuf;
using isogame;

namespace SRRUtil
{
    partial class SRRUtil_MainFrm : Form
    {
        private static string _filename = String.Empty;
        private static string _filepath = String.Empty;

        public SRRUtil_MainFrm()
        {
            InitializeComponent();
            initControls();
            lblToolStripStatus.Text = "Created by qwertyslayer for /r/ShadowrunReturns";
        }

        private void deserializeBytesFile(string filepath)
        {
            initControls();
            string[] uriChunks = filepath.Split('\\');
            _filename = uriChunks[uriChunks.Length-1];
            _filepath = filepath;
            if (!File.Exists(filepath) || Path.GetExtension(filepath) != ".bytes" )
            {
                lblToolStripStatus.Text = "Invalid filepath";
                return;
            }

            FileStream fs = new FileStream(filepath, FileMode.Open);
            ItemDef item = null;
            try
            {
                item = Serializer.Deserialize<ItemDef>(fs); //TODO: expand to include all classes in isogame namespace
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error loading ItemDef: {0}", ex.Message));
            }
            finally
            {
                fs.Close();
            }
            if (loadItem(item))
            {
                lblToolStripStatus.Text = String.Format("Successfully loaded {0}", _filename);
            }
            else
            {
                lblToolStripStatus.Text = "ERROR";
            }
            fs.Close();
        }

        private bool loadItem(ItemDef item)
        {
            bool result = false;
            try
            {
                txtID.Text = item.id;
                cboType.SelectedIndex = cboType.FindString(item.type.ToString());
                loadUIRep(item.uirep);
                txtPrefab.Text = item.equipPrefabName;
                cboAnimType.SelectedIndex = cboAnimType.FindString(item.anim_type.ToString());
                cboCoreAttribute.SelectedIndex = cboCoreAttribute.FindString(item.coreAttribute.ToString());
                cboCoreSkill.SelectedIndex = cboCoreSkill.FindString(item.coreSkill.ToString());
                cboCoreSpec.SelectedIndex = cboCoreSpec.FindString(item.coreSpecialization.ToString());
                nudAmmo.Value = item.maxAmmo;
                nudAP.Value = item.apCost;

                StringBuilder prereqs = new StringBuilder();
                foreach (string pr in item.prereqStrings)
                {
                    prereqs.Append(String.Format("{0};", pr)); //not sure how this is delimited, leave as ; for now
                }

                txtPrereq.Text = prereqs.ToString();
                nudHPDmg.Value = (decimal)item.baseHPDamage;
                nudAPDmg.Value = (decimal)item.baseAPDamage;
                //BindingList<float> bl = new BindingList<float>(item.rangeModTable);
                //dgRangeModTable.DataSource = bl;

                for (int i = 0; i <= item.rangeModTable.Count - 1; i++) //range mod table
                {
                    dgRangeModTable.Rows.Add(1);
                    dgRangeModTable[0, i].Value = i;
                    dgRangeModTable[1, i].Value = item.rangeModTable[i];
                }

                nudNoiseLvl.Value = (decimal)item.noiseLevel;
                nudNoiseRds.Value = item.noiseRounds;
                nudReload.Value = item.ammoReloadAPCost;

                for (int i = 0; i <= item.abilityModes.Count - 1; i++) //ability modes checked list
                {
                    chklstAbilityModes.Items.Add(item.abilityModes[i]); //these aren't enumerated in ShadowrunDTO.dll anywhere,
                    chklstAbilityModes.SetItemChecked(i, true);         //need a way to add new ones (burst fire, full auto, etc)
                }

                nudPrice.Value = item.store_cost;
                chkAffectsEnemy.Checked = item.affectsEnemy;
                chkTargetActor.Checked = item.canTargetActor;
                txtSortingGroup.Text = item.sorting_group;

                if (item.equippedStatusEffects != null)
                {
                    for (int i = 0; i <= item.equippedStatusEffects.statMods.Count - 1; i++) //equip status table
                    {
                        StatMod sm = item.equippedStatusEffects.statMods[i];
                        dgEquipStatus.Rows.Add(1);
                        dgEquipStatus[0, i].Value = sm.attribute;
                        dgEquipStatus[1, i].Value = sm.floatModValue;
                        dgEquipStatus[2, i].Value = sm.intModValue;
                        dgEquipStatus[3, i].Value = sm.skill;
                        dgEquipStatus[4, i].Value = sm.specialization;
                    }
                }
                else
                {
                    dgEquipStatus.Rows.Add(1); //to add your own
                }

                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error during load: {0}", ex.Message));
                result = false;
            }
            return result;
        }

        private void loadUIRep(UIRep uirep) //TODO: delegate methods for subclasses like this in other object types
        {
            txtIcon.Text = uirep.icon;
            txtName.Text = uirep.name;
            txtDescription.Text = uirep.description;
        }

        private void saveUIRep(ItemDef item)
        {
            UIRep uirep = new UIRep();
            uirep.name = txtName.Text;
            uirep.icon = txtIcon.Text;
            uirep.description = txtDescription.Text;
            item.uirep = uirep;
        }

        private ItemDef saveItem()
        {
            var item = new ItemDef();

            item.id = txtID.Text;
            item.type = (ItemType)cboAnimType.SelectedItem;
            saveUIRep(item);
            item.equipPrefabName = txtPrefab.Text;
            item.anim_type = (AnimType)cboAnimType.SelectedItem;
            item.coreAttribute = (isogame.Attribute)cboCoreAttribute.SelectedItem;
            item.coreSkill = (Skill)cboCoreSkill.SelectedItem;
            item.coreSpecialization = (Specialization)cboCoreSpec.SelectedItem;
            item.maxAmmo = (int)nudAmmo.Value;
            item.apCost = (int)nudAP.Value;

            foreach (string prereq in txtPrereq.Text.Split(';'))
            {
                if (prereq.Length > 0) item.prereqStrings.Add(prereq);
            }

            item.baseHPDamage = (int)nudHPDmg.Value;
            item.baseAPDamage = (int)nudAPDmg.Value;

            foreach (DataGridViewRow mod in dgRangeModTable.Rows)
            {
                if (mod.Cells[1].Value != null) item.rangeModTable.Add((float)mod.Cells[1].Value);
            }

            item.noiseLevel = (int)nudNoiseLvl.Value;
            item.noiseRounds = (int)nudNoiseRds.Value;
            item.ammoReloadAPCost = (int)nudReload.Value;

            for (int i = 0; i < chklstAbilityModes.Items.Count; i++)
            {
                if (chklstAbilityModes.GetItemChecked(i))
                {
                    item.abilityModes.Add(chklstAbilityModes.Items[i].ToString());
                }
            }

            item.store_cost = (int)nudPrice.Value;
            item.affectsEnemy = chkAffectsEnemy.Checked;
            item.canTargetActor = chkTargetActor.Checked;
            item.sorting_group = txtSortingGroup.Text;

            foreach (DataGridViewRow es in dgEquipStatus.Rows)
            {
                if (es.Cells[1].Value != null) //there is a better way to do this
                {
                    StatMod sm = new StatMod();
                    sm.attribute = (isogame.Attribute)es.Cells[0].Value;
                    sm.floatModValue = (float)es.Cells[1].Value;
                    sm.intModValue = (int)es.Cells[2].Value;
                    sm.skill = (Skill)es.Cells[3].Value;
                    sm.specialization = (Specialization)es.Cells[4].Value;
                    item.equippedStatusEffects.statMods.Add(sm);
                }
            }

            return item;
        }

        private void initControls()
        {
            _filename = String.Empty;
            _filepath = String.Empty;
            lblToolStripStatus.Text = "";
            cboType.DataSource = Enum.GetValues(typeof(ItemType));
            cboType.SelectedIndex = -1;
            cboAnimType.DataSource = Enum.GetValues(typeof(AnimType));
            cboAnimType.SelectedIndex = -1;
            cboCoreAttribute.DataSource = Enum.GetValues(typeof(isogame.Attribute));
            cboCoreAttribute.SelectedIndex = -1;
            cboCoreSkill.DataSource = Enum.GetValues(typeof(Skill));
            cboCoreSkill.SelectedIndex = -1;
            cboCoreSpec.DataSource = Enum.GetValues(typeof(Specialization));
            cboCoreSpec.SelectedIndex = -1;
            foreach (NumericUpDown nud in GetAll(this, typeof(NumericUpDown)))
            {
                nud.Minimum = decimal.MinValue;
                nud.Maximum = decimal.MaxValue;
            }
            foreach (TextBox txt in GetAll(this, typeof(TextBox)))
            {
                txt.Clear();
            }
            chklstAbilityModes.Items.Clear();
            dgRangeModTable.Rows.Clear();
        }

        private IEnumerable<Control> GetAll(Control ctrl, Type type)
        {
            var controls = ctrl.Controls.Cast<Control>();

            return controls.SelectMany(c => GetAll(c, type))
                .Concat(controls)
                .Where(c => c.GetType() == type);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            ofd.Filter = "Bytes Files (.bytes)|*.bytes|All Files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                deserializeBytesFile(ofd.FileName);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();

            sfd.Filter = "Bytes Files (.bytes)|*.bytes|All Files (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.FileName = _filepath;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        Serializer.Serialize(fs, saveItem());
                        lblToolStripStatus.Text = String.Format("Successfully saved {0}", sfd.FileName);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
