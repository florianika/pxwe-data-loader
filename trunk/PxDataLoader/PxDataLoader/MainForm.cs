using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PxDataLoader.Model;
using System.Configuration;

namespace PxDataLoader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tvMenuSelection_AfterSelect(object sender, TreeViewEventArgs e)
        {
            PxMenuSelection menuSelection = (PxMenuSelection)tvMenuSelection.SelectedNode.Tag;

            if (menuSelection.LevelNo == "5")
            {
                btnEditTable.Visible = true;
            }
            else
            {
                btnEditTable.Visible = false;
            }

            pxMenuSelectionBindingSource.DataSource = menuSelection;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(ConfigurationManager.ConnectionStrings["PcAxisDatabase"].ConnectionString);
            //PxMetaModel.PcAxisMetabaseEntities db = new PxMetaModel.PcAxisMetabaseEntities();
            //loading the treeview items
            var menuStart = VariableFacade.GetMenuStart();
            TreeNode start = tvMenuSelection.Nodes.Add(menuStart.PresText );
            start.Name = menuStart.Menu;
            start.Tag = menuStart;
            PopulateTree(start);
            TreeViewFormat(start);

            presentationComboBox.DataSource = Option.GetOptions("Presentation");
            presentationEnglishComboBox.DataSource = Option.GetOptions("Presentation");
        }

        private void PopulateTree(TreeNode node)
        {

            PxMenuSelection sel = (PxMenuSelection)node.Tag;
            VariableFacade.LoadChildren(sel);

            foreach (var theme in sel.Childrens)
            {
                TreeNode newTheme = new TreeNode();
                newTheme.Name = theme.Menu;
                newTheme.Text = theme.PresText;
                newTheme.Tag = theme;
                
                if (theme.LevelNo != "5")
                {
                    PopulateTree(newTheme);
                }

                node.Nodes.Add(newTheme);

            }
        }

        private void TreeViewFormat(TreeNode tv)
        {
            foreach (TreeNode tn in tv.Nodes)
            {
                PxMenuSelection sel = (PxMenuSelection)tn.Tag;
                if (sel.LevelNo.Equals("5"))
                {
                    tn.ForeColor = Color.Red;
                }
                else
                { 
                    TreeViewFormat(tn);
                }
            }

        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            PxMenuSelection selectedMenu = (PxMenuSelection)tvMenuSelection.SelectedNode.Tag;
            int levelNo;
            int.TryParse(selectedMenu.LevelNo, out levelNo);
            if (levelNo < 4)
            {
                CreateMenuSelectionDialog frmCreateDialog = new CreateMenuSelectionDialog();
                frmCreateDialog.NewMenuSelection.Parent = selectedMenu;
                frmCreateDialog.NewMenuSelection.LevelNo = (levelNo + 1).ToString();
                if (frmCreateDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    selectedMenu.Childrens.Add(frmCreateDialog.NewMenuSelection);
                    TreeNode newTheme = new TreeNode();
                    newTheme.Name = frmCreateDialog.NewMenuSelection.Menu;
                    newTheme.Text = frmCreateDialog.NewMenuSelection.PresText;
                    newTheme.Tag = frmCreateDialog.NewMenuSelection;

                    tvMenuSelection.SelectedNode.Nodes.Add(newTheme);
                    tvMenuSelection.SelectedNode = newTheme;
                }
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            
            PxMenuSelection selectedMenu = (PxMenuSelection)tvMenuSelection.SelectedNode.Tag;
            int levelNo;
            int.TryParse(selectedMenu.LevelNo, out levelNo);
            if (levelNo < 5)
            {
                CreateMainTable frmCreateDialog = new CreateMainTable();

                frmCreateDialog.NewMainTable.Theme = selectedMenu.GetTheme(selectedMenu);
                if (selectedMenu.GetTheme(selectedMenu) == null)
                {
                    MessageBox.Show("Can not insert a table in this node", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmCreateDialog.SetTheme(frmCreateDialog.NewMainTable.Theme);
               
                if (frmCreateDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    PxMenuSelection newMenuSelection = new PxMenuSelection();
                    newMenuSelection.Parent = selectedMenu;
                    newMenuSelection.LevelNo = "5";
                    newMenuSelection.PresText = frmCreateDialog.NewMainTable.PresText;
                    newMenuSelection.PresTextEnglish = frmCreateDialog.NewMainTable.TableTitleEnglish;
                    newMenuSelection.Menu = frmCreateDialog.NewMainTable.TableId;
                    newMenuSelection.Presentation = "A";
                    newMenuSelection.PresentationEnglish = "A";

                    string message = "";

                    if (!newMenuSelection.Validate(ref message))
                    {
                        MessageBox.Show(message, "Create Menu Selection", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        return;
                    }

                    if (!VariableFacade.Save(newMenuSelection, ref message))
                    {
                        MessageBox.Show(message, "Create Menu Selection", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        return;
                    }

                    selectedMenu.Childrens.Add(newMenuSelection);
                    TreeNode newTheme = new TreeNode();
                    newTheme.Name = newMenuSelection.Menu;
                    newTheme.Text = newMenuSelection.PresText;
                    newTheme.Tag = newMenuSelection;

                    tvMenuSelection.SelectedNode.Nodes.Add(newTheme);
                    tvMenuSelection.SelectedNode = newTheme;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (VariableFacade.UpdateMenuSelection((PxMenuSelection)pxMenuSelectionBindingSource.DataSource))
            {
                MessageBox.Show("Menu selection saved succesfuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Can not save Menu Selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void btnAddTimePeriods_Click(object sender, EventArgs e)
        {
            CreateMainTable frmCreateMainTable = new CreateMainTable();
            frmCreateMainTable.NewMainTable = VariableFacade.GetMainTableById(menuTextBox.Text);
            frmCreateMainTable.SetEditMode();
            frmCreateMainTable.ShowDialog();
        }

        private void btnDeleteNode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This action will delete the table from the metadata and data. Are you sure? ", "Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                PxMenuSelection selectedMenu = (PxMenuSelection)tvMenuSelection.SelectedNode.Tag;
                int levelNo;
                int.TryParse(selectedMenu.LevelNo, out levelNo);
                if (levelNo < 5)
                {
                    //check if node has a table
                    if (tvMenuSelection.SelectedNode.Nodes.Count > 0)
                    {
                        MessageBox.Show("Could not delete this node it has subnodes, delete those first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        string msg = "";
                        if (VariableFacade.Delete(selectedMenu, ref msg))
                        {
                            MessageBox.Show("The node was deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                //the node is a table
                else
                {
                    string msg = "";
                    string msg2 = "";
                    string msg3 = "";
                    PxMainTable mt = VariableFacade.GetMainTableById(selectedMenu.Menu);
                   
                        if (VariableFacade.Delete(mt, ref msg))
                        {
                            if (VariableFacade.Delete(selectedMenu, ref msg2))
                            {
                                if (mt != null)
                                {
                                    if (VariableFacade.DeleteDataTable(mt.TableId, ref msg3))
                                    {
                                        MessageBox.Show("The table was deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show(msg3, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    if (VariableFacade.DeleteDataTable(selectedMenu.Menu, ref msg3))
                                    {
                                        MessageBox.Show("The table was deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show(msg3, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show(msg2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                 
                        }

                        else
                        {
                            MessageBox.Show(msg + "\n\n" + msg2 + "\n\n" + msg3, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                 


                }
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenericSettings gs = new GenericSettings();
            gs.ShowDialog();
        }



    }
}
