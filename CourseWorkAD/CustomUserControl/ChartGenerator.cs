﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CourseWorkAD.Model;

/* METHODS AND IT'S CONTENTS
 * ****************************************************************************************************************
 * METHOD 1 : Set check list box items
 * METHOD 2 : Check list box item check event handaler
 * METHOD 3 : Generate pie chart
 * METHOD 4 : Button refrech click listener for updating pie chart.
 * METHOD 5 : Set tree view and categories wise total sales dictionary.
 * ****************************************************************************************************************
 */

namespace CourseWorkAD.CustomUserControl {

    public partial class ChartGenerator : UserControl {

        //private Dictionary<string, int> tempTotalSalesCollection = new Dictionary<string, int>();
        private Dictionary<string, int> totalSalesCollection = BillGenerator.TotalSalesCollection;
        private List<Item> itemList = MenuItem.ItemList;
        private Dictionary<string, int> categoryTotalSales = new Dictionary<string, int>();
        public static Boolean changesInChart = false;

        // System build constructor
        public ChartGenerator() {
            InitializeComponent();  // System build method to load all components belongs to this class
            SetTreeView();
            GeneratePieChart();
        }

        /* METHOD : (1)
         * ********************************************************************************************************
         * Clear checkListBox items first to prevent duplication of item name.
         * Then Loop through dectionary totalSalesCollection and add items for checkListBox control.
         * ********************************************************************************************************
         */
        /*internal void SetCheckListBoxItem() {

            clbSoldItems.Items.Clear();
            foreach (KeyValuePair<string, int> revenues in totalSalesCollection) {
                clbSoldItems.Items.Add(revenues.Key, true);
            }

        }*/

        /* METHOD : (2)
         * ********************************************************************************************************
         * If CheckListBox item is checked then item name and price will be stored into temp dectionary
         * Chart points will be cleared and finally call GeneratePieChart method to create pie chart.
         * In case of uncheck remove item from temp dectionary, clear points and call GeneratePieChart method.
         * ********************************************************************************************************
         */
        /*private void ClbSoldItems_ItemCheck(object sender, ItemCheckEventArgs e) {

            if (clbSoldItems.GetItemCheckState(e.Index) == CheckState.Unchecked) {

                // clbSoldItems.SelectedItem.ToString(); This method cannot be called from here to get name of the item 
                //  because item is uncheck before triggering this part.
                // So we ware using below way to get item name
                string itemName = clbSoldItems.Items[e.Index].ToString();
                this.tempTotalSalesCollection.Add(itemName, totalSalesCollection[itemName]);
                pcRevenue.Series["revenue"].Points.Clear();
                GeneratePieChart();

            } else {

                tempTotalSalesCollection.Remove(clbSoldItems.SelectedItem.ToString());
                pcRevenue.Series["revenue"].Points.Clear();
                GeneratePieChart();   
                
            }

        }*/

        /* METHOD : (3)
         * ********************************************************************************************************
         * ColorGenerator class is used to generate random color for pie chart.
         * Loop through categoryTotalSales dictionary add points to pie chart.
         * ********************************************************************************************************
         */
        private void GeneratePieChart() {
            // Creating object
            // Range has been provided from 0 to size of dectionary because we dont need more distinct color than number of items.
            ColorGenerator.ColorGenerator colorGenerator = new ColorGenerator.ColorGenerator(System.Linq.Enumerable.Range(0, totalSalesCollection.Count));
            int index = 0;  // For pie chart points index

            foreach (KeyValuePair<string, int> totalSales in categoryTotalSales) {
                string itemName = totalSales.Key;
                string revenue = totalSales.Value.ToString("N");
                pcRevenue.Series["revenue"].Points.Add(int.Parse(revenue, System.Globalization.NumberStyles.Currency));
                pcRevenue.Series["revenue"].Points[index].Color = colorGenerator.GetEnumerator().Current;
                pcRevenue.Series["revenue"].Points[index].LabelForeColor = Color.Black;
                pcRevenue.Series["revenue"].Points[index].LegendText = itemName;
                pcRevenue.Series["revenue"].Points[index].Label = revenue.ToString();
                pcRevenue.Series["revenue"].Points[index].ToolTip = "Total revenue of :-\n" + itemName + " : " + "Rs. " + revenue;
                index++;
            }

        }

        /* METHOD : (4)
         * ********************************************************************************************************
         * Clear dectionary and recreate trree view and chart.
         * If there is not anything to update then display message.
         * ********************************************************************************************************
         */
        private void BtnRefresh_Click(object sender, EventArgs e) {

            categoryTotalSales.Clear();     // Clear dictionary
            treeViewRevenue.Nodes.Clear();  // Clear tree view
            SetTreeView();                  // Re-create tree view
            pcRevenue.Series["revenue"].Points.Clear(); // Clear chart points
            GeneratePieChart();             // Re-create chart points

            // If there isnt any changes display message
            if (!changesInChart) {
                MessageBox.Show("Chart is alrady in updated position. \nNo new data to update.", " Update Information ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            changesInChart = false; // After changes set flag to false.

        }

        /* METHOD : (5)
        * ********************************************************************************************************
        * Set tree view of total sales using category name and item name. 
        * Generate dictionary which holds categories wise total sales.
        * ********************************************************************************************************
        */
        private void SetTreeView() {

            List<string> category = MenuItem.CategoryList;  // Total categories
            List<string> soldItems = new List<string>();    // List of sold items name

            // Looping through totlas sales collection to generate list of item name
            foreach (string itemName in totalSalesCollection.Keys) {
                soldItems.Add(itemName);
            }

            // Add treeview top nodes and expand it
            treeViewRevenue.Nodes.Add("Total Sales").ExpandAll();

            for (int i = 1; i < category.Count; i++) {              // Loop category list

                treeViewRevenue.Nodes[0].Nodes.Add(category[i]);    // Set category nodes under top nodes

                for (int j = 0; j < itemList.Count; j++) {          // Loop through total item list

                    string name = itemList[j].ItemName; // item name
                    string cata = itemList[j].ItemCategory; // item category

                    // If sold items has item name and category from first loop is equal to item category
                    if (soldItems.Contains(name) && category[i].Equals(cata)) { 

                        // Add item nodes below category nodes
                        treeViewRevenue.Nodes[0].Nodes[i-1].Nodes.Add(name);
                        
                        // If dictionary categoryTotalSales contain this category then update price else insert into dictionary
                        if(categoryTotalSales.ContainsKey(category[i])) {

                            categoryTotalSales[category[i]] += totalSalesCollection[name];  // Update price
                        } else {

                            categoryTotalSales.Add(category[i], totalSalesCollection[name]);    // Add item
                        }

                    }

                }
            }

        }

    }

}
