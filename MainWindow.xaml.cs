using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_122_L9_ListBoxes_ComboBoxes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        // New List of students favorite colors
        List<string> StudentsFavoriteColors = new List<string>();
        List<string> studenNames = new List<string>();  
        public MainWindow()
        {
            InitializeComponent();

            // .add()

            //rtbDisplay.Text = StudentsFavoriteColors[2];
            //rtbDisplay.Text += "Carlos favorite color is white";
            preload();

            Display(StudentsFavoriteColors);
            //Display(studenNames);

            // listBox - Mames 
            lboxNames.ItemsSource = studenNames;
            cbxColors.ItemsSource = StudentsFavoriteColors;
            // Combo Box - colors
        }//MainWindow

        public void preload()
        {
            StudentsFavoriteColors.Add("Hafsa - Black");
            StudentsFavoriteColors.Add("Matt - Orange");
            StudentsFavoriteColors.Add("Benel - Green");
            StudentsFavoriteColors.Add("David - Pink");
            StudentsFavoriteColors.Add("Kira - Purple");
            StudentsFavoriteColors.Add("Juan - Light cornflower blue");
            StudentsFavoriteColors.Add("Benel - Green");
            //Display();
            studenNames.Add("Marco");
            studenNames.Add("Polo");
            studenNames.Add("Paco");
            studenNames.Add("Loco");
        }
        public void Display()
        {
            rtbDisplay.Text = "";
            for (int i = 0; i < StudentsFavoriteColors.Count; i++)
            {
                rtbDisplay.Text += StudentsFavoriteColors[i] + "\n";
            }

        }

        public void Display(List<string> list) 
        {
            rtbDisplay.Text = "";
            for (int i = 0; i < list.Count; i++)
            {
                rtbDisplay.Text += list[i] + "\n";
            }

        }

        // A collection in programming is any 
        // data structure that holds multiple
        // variables of the same type

        // array or list

        //Lists<type> ListName = new List<type>();
        List<string> strings = new List<string>();  

        // Add 
        // Access
        // Remove

    }
}//Class
//namespace
