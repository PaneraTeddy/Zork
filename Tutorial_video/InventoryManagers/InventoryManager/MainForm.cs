using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using InventoryManager.Data;
using InventoryManager.ViewModels;

namespace InventoryManager
{
    public partial class MainForm : Form
    {
        private WorldViewModel ViewModel 
        { 
            get => mViewModel;
            set
            {
                if(mViewModel != value)
                {
                    mViewModel = value;
                    worldViewModelBindingSource.DataSource = mViewModel;
                }
            }         
        }
        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.FileName = openFileDialog.FileName;
            }
        }
        
        private WorldViewModel mViewModel;
    }
}
