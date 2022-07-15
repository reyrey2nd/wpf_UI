﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ModernUI
{
    /// <summary>
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////
        // THIS IS THE PARENT CONNECTION CLASS.
        // I SEPERATED IT TO AVOID REPITITION
        ///////////////////////////////////////////////
        public static class mainConnectionClass
        {

            private static string connect_query = "SERVER=localhost;DATABASE=mydb;UID=root;PASSWORD=admin;";
            public static MySqlConnection conn = new MySqlConnection(connect_query);

            public static string query = "SELECT * FROM users WHERE username=@username && password=@password";

            public static string staffID = "";
            public static string staffFirstName = "";
            public static string staffLastName = "";
            public static string role = "";
        }

        private void Border_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbox_Password.Password) && txtbox_Password.Password.Length > 0)
                textPassword.Visibility = Visibility.Collapsed;
            else
                textPassword.Visibility = Visibility.Visible;
        }

        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtbox_Password.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ///////////////////////////////////////////////
            // THIS CHECKS THE FIELD OF USERNAME AND
            // PASSWORD IF NOT EMPTY. 
            ///////////////////////////////////////////////
            MySqlCommand command = new MySqlCommand(mainConnectionClass.query, mainConnectionClass.conn);

            command.Parameters.AddWithValue("@username", txtbox_Username.Text);
            command.Parameters.AddWithValue("@password", txtbox_Password.Password);

            mainConnectionClass.conn.Open();
            if (!string.IsNullOrEmpty(txtbox_Username.Text) && !string.IsNullOrEmpty(txtbox_Password.Password))
            {

                ///////////////////////////////////////////////
                // This initializes the connection to database. 
                // I inherited the mainconnection class to child class and used it
                // 
                // PASSWORD IF NOT EMPTY. 
                ///////////////////////////////////////////////
                ///
                ///////////////////////////////////////////////
                // This returns the result from the query above
                // Line: 82. 
                ///////////////////////////////////////////////
                try
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            HomeWindow HomeWindow = new HomeWindow();
                            txtbox_Username.Clear();
                            txtbox_Password.Clear();

                            mainConnectionClass.staffID = reader[0].ToString();
                            mainConnectionClass.staffFirstName = reader[1].ToString();
                            mainConnectionClass.staffLastName = reader[2].ToString();
                            mainConnectionClass.role = reader[5].ToString();


                            HomeWindow.txtbox_ReportedByStaffID.Text = mainConnectionClass.staffID;
                            HomeWindow.txtbox_ReportedByStaffName.Text = mainConnectionClass.staffFirstName + " " + mainConnectionClass.staffLastName;
                            HomeWindow.text_LoggedInAs.Text += mainConnectionClass.role == "1" ? "Supervisor" : "Staff User";
                            HomeWindow.text_LoggedInAs.Text += ", " + mainConnectionClass.staffFirstName;

                            HomeWindow.txtbox_Role.Text = mainConnectionClass.role == "1" ? "Supervisor" : "Staff User";

                            _ = mainConnectionClass.role == "1" ? HomeWindow.grid_Supervisor.Visibility = Visibility.Visible : HomeWindow.grid_Supervisor.Visibility = Visibility.Collapsed;


                            this.Close();
                            HomeWindow.Show();

                            
                        }
                        mainConnectionClass.conn.Close();
                    }
                    else
                    {
                        mainConnectionClass.conn.Close();
                        MessageBox.Show("mali bonak");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }


        private void txtEmail_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbox_Username.Text) && txtbox_Username.Text.Length > 0)
                textEmail.Visibility = Visibility.Collapsed;
            else
                textEmail.Visibility = Visibility.Visible;
        }

        private void textEmail_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtbox_Username.Focus();
        }

    }

}