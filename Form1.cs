﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LengthCalculator
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            // 給予每一個輸入文字框一個「空字串」
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
        }

        private void txtCM_KeyUp_1(object sender, KeyEventArgs e)
        {
            double douCM; //宣告一個double變數，變數名稱叫douCM

            douCM = Convert.ToDouble(txtCM.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtM.Text = string.Format("{0:0.##########}", douCM / 100);
            //將douCM的數值除以100，也就是從公分轉換成公尺
            //透過string.Format格式化成小數點後共10位的數字，轉型成文字型態，在txtM顯示結果
            txtKM.Text = string.Format("{0:0.##########}", douCM / 10000);
            txtIn.Text = string.Format("{0:0.##########}", douCM / 2.54);
            txtFt.Text = string.Format("{0:0.##########}", douCM / 30.48);
            txtYard.Text = string.Format("{0:0.##########}", douCM / 91.44);

        }

        private void txtCM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            double douM; //宣告一個double變數，變數名稱叫douM

            douM = Convert.ToDouble(txtM.Text); //從txtM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtCM.Text = string.Format("{0:0.##########}", douM * 100);
            //將douM的數值乘以100，也就是從公尺轉換成公分
            //透過string.Format格式化成小數點後共10位的數字，轉型成文字型態，在txtCM顯示結果
            txtKM.Text = string.Format("{0:0.##########}", douM / 1000);
            txtIn.Text = string.Format("{0:0.##########}", douM * 39.3701);
            txtFt.Text = string.Format("{0:0.##########}", douM * 3.28084);
            txtYard.Text = string.Format("{0:0.##########}", douM * 1.09361);
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            double douKM; //宣告一個double變數，變數名稱叫douKM

            douKM = Convert.ToDouble(txtKM.Text); //從txtKM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtM.Text = string.Format("{0:0.##########}", douKM * 1000);
            //將douKM的數值乘以1000，也就是從公里轉換成公尺
            //透過string.Format格式化成小數點後共10位的數字，轉型成文字型態，在txtM顯示結果
            txtCM.Text = string.Format("{0:0.##########}", douKM * 100000);
            txtIn.Text = string.Format("{0:0.##########}", douKM * 39370.1);
            txtFt.Text = string.Format("{0:0.##########}", douKM * 3280.84);
            txtYard.Text = string.Format("{0:0.##########}", douKM * 1093.61);
        }

        private void txtIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            double douIn; //宣告一個double變數，變數名稱叫douIn

            douIn = Convert.ToDouble(txtIn.Text); //從txtIn輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtCM.Text = string.Format("{0:0.##########}", douIn * 2.54);
            //將douIn的數值乘以2.54，也就是從英吋轉換成公分
            //透過string.Format格式化成小數點後共10位的數字，轉型成文字型態，在txtCM顯示結果
            txtM.Text = string.Format("{0:0.##########}", douIn * 0.0254);
            txtKM.Text = string.Format("{0:0.##########}", douIn * 0.0000254);
            txtFt.Text = string.Format("{0:0.##########}", douIn / 12);
            txtYard.Text = string.Format("{0:0.##########}", douIn / 36);
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            double douFt; //宣告一個double變數，變數名稱叫douFt

            douFt = Convert.ToDouble(txtFt.Text); //從txtFt輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtCM.Text = string.Format("{0:0.##########}", douFt * 30.48);
            //將douFt的數值乘以30.48，也就是從英呎轉換成公分
            //透過string.Format格式化成小數點後共10位的數字，轉型成文字型態，在txtCM顯示結果
            txtM.Text = string.Format("{0:0.##########}", douFt * 0.3048);
            txtKM.Text = string.Format("{0:0.##########}", douFt * 0.0003048);
            txtIn.Text = string.Format("{0:0.##########}", douFt * 12);
            txtYard.Text = string.Format("{0:0.##########}", douFt / 3);
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            double douYard; //宣告一個double變數，變數名稱叫douYard

            douYard = Convert.ToDouble(txtYard.Text); //從txtYard輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtCM.Text = string.Format("{0:0.##########}", douYard * 91.44);
            //將douYard的數值乘以91.44，也就是從碼轉換成公分
            //透過string.Format格式化成小數點後共10位的數字，轉型成文字型態，在txtCM顯示結果
            txtM.Text = string.Format("{0:0.##########}", douYard * 0.9144);
            txtKM.Text = string.Format("{0:0.##########}", douYard * 0.0009144);
            txtIn.Text = string.Format("{0:0.##########}", douYard * 36);
            txtFt.Text = string.Format("{0:0.##########}", douYard * 3);
        }
    }
}
