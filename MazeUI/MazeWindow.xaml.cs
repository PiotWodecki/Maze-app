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
using System.Windows.Shapes;

namespace MazeUI
{
    /// <summary>
    /// Interaction logic for MazeWindow.xaml
    /// </summary>
    public partial class MazeWindow : Window
    {
        private Grid maze;
        private static int cells = 20;
        public MazeWindow()
        {
            InitializeComponent();
            maze = new Grid();

            for(int i = 0; i < cells; i++)
            {
                maze.RowDefinitions.Add(new RowDefinition());
                maze.ColumnDefinitions.Add(new ColumnDefinition());
            }
            
            for(int i = 0; i < cells; i++)
                for(int j = 0; j < cells; j++)
                {
                    TextBlock tx = new TextBlock();
                    tx.FontSize = 20;
                    tx.TextAlignment = TextAlignment.Center;
                    tx.VerticalAlignment = VerticalAlignment.Center;
                    tx.Text = "X";
                    Grid.SetRow(tx,i);
                    Grid.SetColumn(tx, j);
                    maze.Children.Add(tx);
                }

            
            Grid.SetRow(maze, 0);
            Grid.SetColumn(maze, 0);

            mazeWrapper.Children.Add(maze);

            Cell[][] c = MazeGenerator.generate(20);
        }
    }
}
