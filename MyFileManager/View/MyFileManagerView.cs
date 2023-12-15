using MyFileManager.Controllers;
using MyFileManager.Helpers;
using MyFileManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFileManager.View
{
    public partial class MyFileManagerView : Form
    {
        DirectoriesManagementController directoriesManagementController;
        List<MyDirectoryItem> itemsList1;
        List<MyDirectoryItem> itemsList2;
        string currentDirectory1;
        string currentDirectory2;

        public MyFileManagerView()
        {
            InitializeComponent();

            gvFileList1.AllowDrop = true;
            gvFileList2.AllowDrop = true;

            cmbGv1Drives.Items.AddRange(DriveInfo.GetDrives().Select(d => d.Name).ToArray());
            cmbGv2Drives.Items.AddRange(DriveInfo.GetDrives().Select(d => d.Name).ToArray());
            directoriesManagementController = new DirectoriesManagementController();

            initializeComboboxesAndCurrentDirs();

            //inicjalizuj dane na gridach
            itemsList1 = directoriesManagementController.DownlowadDirectiries
                (currentDirectory1);
            itemsList1.ForEach(i => i.GridViewName = gvFileList1.Name);
            itemsList2 = directoriesManagementController.DownlowadDirectiries
                (currentDirectory2);
            itemsList2.ForEach(i => i.GridViewName = gvFileList2.Name);

            gvFileList1.DataSource = itemsList1;
            gvFileList1.Refresh();

            gvFileList2.DataSource = itemsList2;
            gvFileList2.Refresh();
        }

        /// <summary>
        /// Inicjalizuje wartości na comboboxach oraz domyślne ścieżki dla gridów
        /// </summary>
        private void initializeComboboxesAndCurrentDirs()
        {
            if (cmbGv1Drives.Items.Count > 0)
            {
                cmbGv1Drives.SelectedIndex = 0;
                currentDirectory1 = cmbGv1Drives.SelectedItem.ToString();
            }
            else
            {
                currentDirectory1 = Directory.GetDirectoryRoot(Directory.GetCurrentDirectory());
            }

            if (cmbGv2Drives.Items.Count > 0)
            {
                cmbGv2Drives.SelectedIndex = 0;
                currentDirectory2 = cmbGv2Drives.SelectedItem.ToString();
            }
            else
            {
                currentDirectory2 = Directory.GetDirectoryRoot(Directory.GetCurrentDirectory());
            }
        }

        /// <summary>
        /// Ustawia listę ścieżek dla wybranego Grida
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="dataGridView"></param>
        private void setGvDirectoryList(string directory, DataGridView dataGridView, string pathToFocusOn = "")
        {
            if (directory == null)
                return;

            //restartuj nazwy nagłówków
            clearHeaderSortingArrows(dataGridView);

            if (dataGridView.Name == "gvFileList1")
            {
                //Ustaw nową lokalizacje oraz pobierz dla niej listę elementów
                currentDirectory1 = directory;
                itemsList1 = new List<MyDirectoryItem>();
                foreach (MyDirectoryItem item in directoriesManagementController.DownlowadDirectiries(currentDirectory1))
                {
                    item.GridViewName = dataGridView.Name;
                    itemsList1.Add(item);
                }
                if (directoriesManagementController.errorMessages.Count == 0)
                {
                    dataGridView.DataSource = itemsList1;
                    dataGridView.Refresh();

                    //Ustaw focus na wierszu jeżeli jest taka potrzeba/możliwość
                    setFocusOnRow(dataGridView, "colName1", pathToFocusOn);
                }
                else
                {
                    foreach (string err in directoriesManagementController.errorMessages)
                        MessageBox.Show(err, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dataGridView.Name == "gvFileList2")
            {
                //Ustaw nową lokalizacje oraz pobierz dla niej listę elementów
                currentDirectory2 = directory;
                itemsList2 = new List<MyDirectoryItem>();
                foreach (MyDirectoryItem item in directoriesManagementController.DownlowadDirectiries(currentDirectory2))
                {
                    item.GridViewName = dataGridView.Name;
                    itemsList2.Add(item);
                }
                if (directoriesManagementController.errorMessages.Count == 0)
                {
                    dataGridView.DataSource = itemsList2;
                    dataGridView.Refresh();

                    //Ustaw focus na wierszu jeżeli jest taka potrzeba/możliwość
                    setFocusOnRow(dataGridView, "colName2", pathToFocusOn);
                }
                else
                {
                    foreach (string err in directoriesManagementController.errorMessages)
                        MessageBox.Show(err, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        /// <summary>
        /// Ustawia focus na wybranym wierszu, czyszcząc focus na wszystkich pozostałych
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="colName"></param>
        /// <param name="pathToFocusOn"></param>
        private void setFocusOnRow(DataGridView dataGridView, string colName, string pathToFocusOn)
        {
            if (!String.IsNullOrEmpty(pathToFocusOn))
            {
                dataGridView.ClearSelection();
                int matchedColId = dataGridView.Columns[colName]?.Index ?? -1;
                if (matchedColId != -1)
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Cells[matchedColId].Value.ToString() == pathToFocusOn)
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Sortuje wiersze w gridzie po wybranej kolumnie
        /// </summary>
        /// <param name="column"></param>
        /// <param name="sortDirection"></param>
        private void sortGridElements(DataGridViewColumn column, ListSortDirection sortDirection)
        {
            // \u2191 - upwards arrow
            // \u2191 - downwards arrow

            DataGridView grid = column.DataGridView;
            if (grid.Name == "gvFileList1")
            {
                itemsList1 = SortHelper.ReturnItemsListSortedByProperty(itemsList1, column.Name, sortDirection);
                grid.DataSource = itemsList1;
            }
            else if (grid.Name == "gvFileList2")
            {
                itemsList2 = SortHelper.ReturnItemsListSortedByProperty(itemsList2, column.Name, sortDirection);
                grid.DataSource = itemsList2;
            }

            clearHeaderSortingArrows(grid);

            // ustaw odpowiednią ikonę 'strzałki' dla nagłówka sortowanej kolumny
            if (sortDirection == ListSortDirection.Ascending)
                grid.Columns[column.Name].HeaderText += " \u2191";
            else if (sortDirection == ListSortDirection.Descending)
                grid.Columns[column.Name].HeaderText += " \u2193";

            grid.Refresh();
        }

        /// <summary>
        /// Usuwa 'strzałkę' pojawiającą się w nagłówku kolumny gdy aktywne jest sortowanie
        /// </summary>
        /// <param name="grid"></param>
        private void clearHeaderSortingArrows(DataGridView grid)
        {
            for (int headerColId = 0; headerColId < grid.Columns.Count; headerColId++)
            {
                grid.Columns[headerColId].HeaderText =
                    grid.Columns[headerColId].HeaderText.Replace(" \u2191", "").Replace(" \u2193", "");
            }
        }

        private void gvFileList1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (gvFileList1.SelectedRows.Count > 0)
            {
                //wejdź folder głębiej
                MyDirectoryItem myDirItem = gvFileList1.Rows[e.RowIndex].DataBoundItem as MyDirectoryItem;
                if (myDirItem != null && myDirItem.Type == DirectorySystemItemType.Directory)
                    setGvDirectoryList(myDirItem.FullName, gvFileList1);
            }
        }
        private void gvFileList2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (gvFileList2.SelectedRows.Count > 0)
            {
                //wejdź folder głębiej
                MyDirectoryItem myDirItem = gvFileList2.Rows[e.RowIndex].DataBoundItem as MyDirectoryItem;
                if (myDirItem != null && myDirItem.Type == DirectorySystemItemType.Directory)
                    setGvDirectoryList(myDirItem.FullName, gvFileList2);
            }
        }
        private void btnGv1FolderAbove_Click(object sender, EventArgs e)
        {
            //odśwież data source dla grida wchodząc folder wyżej
            string directory = Path.GetDirectoryName(currentDirectory1);
            setGvDirectoryList(directory, gvFileList1, Path.GetFileName(currentDirectory1));
        }
        private void btnGv2FolderAbove_Click(object sender, EventArgs e)
        {
            //odśwież data source dla grida wchodząc folder wyżej
            string directory = Path.GetDirectoryName(currentDirectory2);
            setGvDirectoryList(directory, gvFileList2, Path.GetFileName(currentDirectory2));
        }
        private void gvFileList1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Porównaj listę elementów z jej posortowanym rosnąco odpowiednikiem
            //Jeżeli są takie same, zmień sortowanie na malejące
            //Następnie wywołaj metodę sortującą dobierając odpowiedni typ sortowania
            if (Enumerable.SequenceEqual(itemsList1, SortHelper.ReturnItemsListSortedByProperty
                (itemsList1, gvFileList1.Columns[e.ColumnIndex].Name, ListSortDirection.Ascending)))
            {
                sortGridElements(gvFileList1.Columns[e.ColumnIndex], ListSortDirection.Descending);
            }
            else
            {
                sortGridElements(gvFileList1.Columns[e.ColumnIndex], ListSortDirection.Ascending);
            }
        }
        private void gvFileList2_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Porównaj listę elementów z jej posortowanym rosnąco odpowiednikiem
            //Jeżeli są takie same, zmień sortowanie na malejące
            //Następnie wywołaj metodę sortującą dobierając odpowiedni typ sortowania
            if (Enumerable.SequenceEqual(itemsList2, SortHelper.ReturnItemsListSortedByProperty
                (itemsList2, gvFileList2.Columns[e.ColumnIndex].Name, ListSortDirection.Ascending)))
            {
                sortGridElements(gvFileList2.Columns[e.ColumnIndex], ListSortDirection.Descending);
            }
            else
            {
                sortGridElements(gvFileList2.Columns[e.ColumnIndex], ListSortDirection.Ascending);
            }
        }
        private void gvFileList1_DragEnter(object sender, DragEventArgs e)
        {
            //ustaw efekt Copy dla kursora
            e.Effect = DragDropEffects.Copy;
        }

        /// <summary>
        /// Umożliwia wklejenie elementu przeciągniętego z drugiego grida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvFileList1_DragDrop(object sender, DragEventArgs e)
        {
            MyDirectoryItem dirItem = (MyDirectoryItem)e.Data.GetData(typeof(MyDirectoryItem));
            if (sender is DataGridView && (sender as DataGridView).Name != dirItem.GridViewName)
            {
                // skopiuj i wklej element oraz zwróć stosowny komunikat
                if (directoriesManagementController.CopyPath(dirItem.FullName, currentDirectory1, dirItem.Type))
                {
                    //odśwież grida
                    setGvDirectoryList(currentDirectory1, gvFileList1, dirItem.Name);

                    MessageBox.Show(
                        $"Skopiowano element '{dirItem.Name}' do ścieżki '{currentDirectory1}'", "Sukces!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(
                        $"Nie udało się skopiować elementu '{dirItem.Name}' do ścieżki '{currentDirectory1}'", "Błąd!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Umożliwia rozpoczęcie akcji "przesuń i upuść"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvFileList1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DataGridView.HitTestInfo hitTest = gvFileList1.HitTest(e.X, e.Y);
                if (hitTest.Type == DataGridViewHitTestType.Cell)
                {
                    MyDirectoryItem dirItem = (MyDirectoryItem)gvFileList1.Rows[hitTest.RowIndex].DataBoundItem;
                    if (dirItem != null)
                        gvFileList1.DoDragDrop(dirItem, DragDropEffects.Copy);
                }
            }
        }
        private void gvFileList2_DragEnter(object sender, DragEventArgs e)
        {
            //ustaw efekt Copy dla kursora
            e.Effect = DragDropEffects.Copy;
        }

        /// <summary>
        /// Umożliwia wklejenie elementu przeciągniętego z drugiego grida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvFileList2_DragDrop(object sender, DragEventArgs e)
        {
            MyDirectoryItem dirItem = (MyDirectoryItem)e.Data.GetData(typeof(MyDirectoryItem));
            if (sender is DataGridView && (sender as DataGridView).Name != dirItem.GridViewName)
            {
                // skopiuj i wklej element oraz zwróć stosowny komunikat
                if (directoriesManagementController.CopyPath(dirItem.FullName, currentDirectory2, dirItem.Type))
                {
                    //odśwież grida
                    setGvDirectoryList(currentDirectory2, gvFileList2, dirItem.Name);

                    MessageBox.Show(
                        $"Skopiowano element '{dirItem.Name}' do ścieżki '{currentDirectory2}'", "Sukces!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(
                        $"Nie udało się skopiować elementu '{dirItem.Name}' do ścieżki '{currentDirectory2}'", "Błąd!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Umożliwia rozpoczęcie akcji "przesuń i upuść"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvFileList2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DataGridView.HitTestInfo hitTest = gvFileList2.HitTest(e.X, e.Y);
                if (hitTest.Type == DataGridViewHitTestType.Cell)
                {
                    MyDirectoryItem dirItem = (MyDirectoryItem)gvFileList2.Rows[hitTest.RowIndex].DataBoundItem;
                    if (dirItem != null)
                        gvFileList2.DoDragDrop(dirItem, DragDropEffects.Copy);
                }
            }
        }

        private void btnGv1DeleteElement_Click(object sender, EventArgs e)
        {
            MyDirectoryItem dirItem = (gvFileList1.SelectedRows[0]?.DataBoundItem as MyDirectoryItem) ?? null;
            deleteElement(dirItem);
        }

        private void btnGv2DeleteElement_Click(object sender, EventArgs e)
        {
            MyDirectoryItem dirItem = (gvFileList2.SelectedRows[0]?.DataBoundItem as MyDirectoryItem) ?? null;
            deleteElement(dirItem);
        }

        /// <summary>
        /// Usuwa wskazany element
        /// </summary>
        /// <param name="dirItem"></param>
        private void deleteElement(MyDirectoryItem dirItem)
        {
            if (dirItem != null)
            {
                //rozpocznij usuwanie tylko jeżeli użytkownik potwierdzi taki zamiar
                if (MessageBox.Show(
                    $"Czy na pewno chcesz usunąć element '{dirItem.FullName}'?\nJest to operacja nieodwracalna!", "Pytanie",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //usuń element i zwróć komunikat
                    if (directoriesManagementController.RemovePath(dirItem.FullName, dirItem.Type))
                    {
                        //odśwież grida
                        if (dirItem.GridViewName == "gvFileList1")
                            setGvDirectoryList(currentDirectory1, gvFileList1);
                        else if (dirItem.GridViewName == "gvFileList2")
                            setGvDirectoryList(currentDirectory2, gvFileList2);

                        MessageBox.Show(
                            $"Element '{dirItem.Name}' został usunięty.", "Sukces!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(
                            $"Podczas usuwania elementu '{dirItem.Name}' wystąpił błąd który uniemożliwił jego usunięcie.", "Błąd!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnGv1DodajElement_Click(object sender, EventArgs e)
        {
            addElement(currentDirectory1);
        }

        private void btnGv2DodajElement_Click(object sender, EventArgs e)
        {
            addElement(currentDirectory2);
        }

        /// <summary>
        /// Dodaje katalog do wskazanej ścieżki
        /// </summary>
        /// <param name="path"></param>
        private void addElement(string path)
        {
            AddElementView addElementView = new AddElementView();
            if (addElementView.ShowDialog() == DialogResult.OK)
            {
                //stwórz ścieżkę dla nowego katalogu i sprawdź czy taka nazwa nie istnieje już we wskazanej lokalizacji
                //jeżeli istnieje, dopasuj nową nazwę
                string pathCombined = Path.Combine(path, addElementView.NazwaKatalogu);
                if (Directory.Exists(pathCombined))
                    pathCombined = directoriesManagementController.FindPathName(pathCombined);

                //dodaj katalog i zwróć stosowny komunikat
                if (directoriesManagementController.CreatePath(pathCombined))
                {
                    // odśwież grida
                    setGvDirectoryList(currentDirectory1, gvFileList1);
                    setGvDirectoryList(currentDirectory2, gvFileList2);

                    MessageBox.Show(
                        $"Element '{pathCombined}' został utworzony.", "Sukces!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(
                        $"Podczas tworzenia elementu '{pathCombined}' wystąpił błąd.", "Błąd!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MyFileManagerView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F8)
            {
                //dopasuj MyDirectoryElement wyciągając go z zaznaczonego wiersza w obecnie zfocusowanym gridzie
                MyDirectoryItem dirItem = null;
                if (gvFileList1.Focused)
                    dirItem  = (gvFileList1.SelectedRows[0]?.DataBoundItem as MyDirectoryItem) ?? null;
                else if (gvFileList2.Focused)
                    dirItem = (gvFileList2.SelectedRows[0]?.DataBoundItem as MyDirectoryItem) ?? null;

                deleteElement(dirItem);
            }
            else if(e.KeyCode == Keys.F7)
            {
                //dodaj element na podstawie ścieżki wybranej na obecnie zfocusowanym gridzie
                if (gvFileList1.Focused)
                    addElement(currentDirectory1);
                else if (gvFileList2.Focused)
                    addElement(currentDirectory2);
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            //zakończ działanie aplikacji
            this.Close();
        }

        private void cmbGv1Drives_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDirectory1 = cmbGv1Drives.SelectedItem?.ToString() ?? String.Empty;
            setGvDirectoryList(currentDirectory1, gvFileList1);
        }

        private void cmbGv2Drives_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDirectory2 = cmbGv2Drives.SelectedItem?.ToString() ?? String.Empty;
            setGvDirectoryList(currentDirectory2, gvFileList2);
        }
    }
}
