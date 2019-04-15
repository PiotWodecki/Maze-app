using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MazeUI
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void getBiggerFont(object sender, MouseEventArgs e)
        {
            FontSize += 10;
        }

        private void get(object sender, MouseEventArgs e)
        {

        }

     
        private void NewGame_button_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        ///  private void PlaySound(object sender, MouseEventArgs e)
        // {
        //     SoundPlayer player = new SoundPlayer(Properties.Resources.mouse_click_single);
        //     player.Play();
        //  }
    }
}
