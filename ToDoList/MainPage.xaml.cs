using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using ToDoList.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ToDoList
{
    /// <summary>
    /// Main page of TODO app. Create and delete tasks. 
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Task> tasks = new ObservableCollection<Task>();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            tasks.Add(new Task(InputBox.Text));
            listBox.ItemsSource = tasks;
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var task in tasks.ToList())
            {
                if (task.Checked)
                {
                    tasks.Remove(task);
                }
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var checkbox = sender as CheckBox;
            var text = checkbox.Content.ToString();
            Debug.WriteLine(text);
            foreach (var task in tasks)
            {
                if (task.TaskText == text)
                {
                    task.Checked = true;
                }
            }
        }
    }
}
