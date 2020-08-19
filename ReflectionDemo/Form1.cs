using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtTypeName.Focus();
        }
        private void BtnDiscoverTypeInfo_Click(object sender, EventArgs e)
        {
            UI();
        }
        private void UI()
        {
            try
            {
                string typeName = txtTypeName.Text;
                if (string.IsNullOrEmpty(typeName))
                {
                    MessageBox.Show("Please fill the textbox first before proceeding.", "The textbox is mandatory!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTypeName.Focus();
                }
                else
                {
                    #region Implementation
                    Type type = Type.GetType(typeName, true);

                    MethodInfo[] methodInfos = type.GetMethods();
                    lbMethods.Items.Clear();
                    int counterMethods = 0;
                    int counterProperty = 0;
                    int counterConstructor = 0;
                    foreach (var method in methodInfos)
                    {
                        lbMethods.Items.Add($"{++counterMethods}. {method}");
                    }

                    PropertyInfo[] propertyInfo = type.GetProperties();
                    lbProperties.Items.Clear();
                    foreach (var property in propertyInfo)
                    {
                        lbProperties.Items.Add($"{++counterProperty}. {property}");
                    }

                    ConstructorInfo[] constructorInfos = type.GetConstructors();

                    lbConstructors.Items.Clear();
                    foreach (var constructors in constructorInfos)
                    {
                        lbConstructors.Items.Add($"{++counterConstructor}. {constructors}");
                    }
                    #endregion
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Some Invalid data was entered.", "Please check the fully qualified name of the type.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTypeName.Focus();
            }
        }

        private void LbMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Select Index Changed Event 
            //Fires when the user select an item
            //in the Method ListBox

            //Check if the user has select an item first..
            if (lbMethods.SelectedIndex != -1)
            {
                string itemSelected = lbMethods.SelectedItem.ToString();
                MessageBox.Show(itemSelected.ToUpper());
            }
            else
            {
                MessageBox.Show("The resource you are looking cannot be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LbProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Select Index Changed Event 
            //Fires when the user select an item
            //in the Properties ListBox

            //Check if the user has select an item first..
            if (lbProperties.SelectedIndex != -1)
            {
                string itemSelected = lbProperties.SelectedItem.ToString();
                MessageBox.Show(itemSelected.ToUpper());
            }
            else
            {
                MessageBox.Show("The resource you are looking cannot be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LbConstructors_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Select Index Changed Event 
            //Fires when the user select an item
            //in the Constructor ListBox

            //Check if the user has select an item first..
            if (lbConstructors.SelectedIndex != -1)
            {
                string itemSelected = lbConstructors.SelectedItem.ToString();
                MessageBox.Show(itemSelected.ToUpper());
            }
            else
            {
                MessageBox.Show("The resource you are looking cannot be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
