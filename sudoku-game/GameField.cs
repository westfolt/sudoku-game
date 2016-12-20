using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace sudoku_game
{
    public class GameField
    {
        private ObservableCollection<Cell> cells;
        public GameField(int size, Grid mainFieldDisplay)
        {
            mainFieldDisplay.RowDefinitions.Clear();
            mainFieldDisplay.ColumnDefinitions.Clear();
            for (int i = 0; i < size; i++)
            {
                ColumnDefinition colDef = new ColumnDefinition();
                mainFieldDisplay.ColumnDefinitions.Add(colDef);
                RowDefinition rowDef = new RowDefinition();
                mainFieldDisplay.RowDefinitions.Add(rowDef);
            }
            cells = new ObservableCollection<Cell>();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Button button = new Button();
                    button.Content = "1";
                    Grid.SetColumn(button,i);
                    Grid.SetRow(button,j);
                    mainFieldDisplay.Children.Add(button);
                }
            }
        }
    }
}
