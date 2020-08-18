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
            string typeName = txtTypeName.Text;
            if (string.IsNullOrEmpty(typeName))
            {
                MessageBox.Show("Please fill the textbox first before proceeding.");
                txtTypeName.Focus();
            }
            else
            {
               
                Type type = Type.GetType(typeName);
               
                MethodInfo[] methodInfos = type.GetMethods();
                lbMethods.Items.Clear();
                int counterMethods = 0;
                int counterProperty = 0;
                int counterConstructor = 0;
                foreach (var method in methodInfos)
                {
                    lbMethods.Items.Add($"{++counterMethods}: {method.Name} : {method.ReturnType.Name}");
                }
               
                PropertyInfo[] propertyInfo = type.GetProperties();
                lbProperties.Items.Clear();
                foreach (var property in propertyInfo)
                {
                    lbProperties.Items.Add($"{++counterProperty}: {property}");
                }
                
                ConstructorInfo[] constructorInfos = type.GetConstructors();
               
                lbConstructors.Items.Clear();
                foreach (var constructors in constructorInfos)
                {
                    lbConstructors.Items.Add($"{++counterConstructor}: {constructors}");
                }
            }
        }
    }
}
