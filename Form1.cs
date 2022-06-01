﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Свойства и методы элемента Button" + '\r' + '\n' +
            "1. SetFocus - устанавливает фокус на данный компонент." + '\r' + '\n' +
            "2. Visible - определяет видимость компонента во время выполнения." + '\r' + '\n' +
            "3. Align - определяет как поведет себя компонент при изменении размеров содержащего его родительского компонента." + '\r' + '\n' +
            "4. Name - определяет наименование компонента." + '\r' + '\n' +
            "События компонента Button" + '\r' + '\n' +
            "1. Событие OnClick наступает, если пользователь осуществил щелчок основной кнопкой мыши в области компонента." + '\r' + '\n' +
            "2. Событие OnVScroll наступает при изменении положения ползунка вертикальной полосы прокрутки." + '\r' + '\n' +
            "3. Событие OnKeyUp наступает, если компонент находится в фокусе, при отпускании пользователем любой, ранее нажатой клавиши." + '\r' + '\n' +
            "4. Событие OnDragDrop для компонента наступает, когда пользователь отпускает над ним перетаскиваемый объект.";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Свойства и методы элемента ComboBox" + '\r' + '\n' +
            "1.Cвойство DropDownStyle задает стиль ComboBox.Оно может принимать три возможных значения:" + '\r' + '\n' +
            "2.Метод ClearEdit осуществляет очистку поля редактирования компонента." + '\r' + '\n' +
            "3.Метод SelectAll осуществляет выделение всего текста в строке редактирования компонента.";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Свойства и методы элемента Label" + '\r' + '\n' +
            "1. Свойство Alignment определяет выравнивание текста по горизонтали." + '\r' + '\n' +
            "2. Свойство AutoSize определяет, будет ли производиться автоматический подгон размеров компонента под текст компонента." + '\r' + '\n' +
            "3. Свойство Transparent определяет признак прозрачности компонента." + '\r' + '\n' +
            "События компонента Label" + '\r' + '\n' +
            "1. Метод DoDragDrop позволяет начать операцию перетаскивания." + '\r' + '\n' +
            "2. Метод ClientToScreen преобразовывает координаты точки, указанные относительно системы координат компонента, в экранные координаты.";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Свойства и методы элемента CheckBox " + '\r' + '\n' +
            "1. Элемент CheckBox или флажок предназначен для установки одного из двух значений: отмечен или не отмечен." + '\r' + '\n' +
            "2. Cвойство CheckState, которое позволяет задать для флажка одно из трех состояний -Checked(отмечен), Indeterminate(флажок не определен - отмечен, но находится в неактивном состоянии) и Unchecked(не отмечен)" + '\r' + '\n' +
            "3. ItemCount возвращает количество строк раскрывающегося списка." + '\r' + '\n' +
            "4. ItemCount возвращает количество строк раскрывающегося списка." + '\r' + '\n' +
            "5. ItemCount возвращает количество строк раскрывающегося списка." + '\r' + '\n' +
            "6. Метод DoDragDrop позволяет начать операцию перетаскивания.";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Свойства и методы элемента PictureBox " + '\r' + '\n' +
            "1. Image: устанавливает объект типа Image" + '\r' + '\n' +
            "2. ImageLocation: устанавливает путь к изображению на диске или в интернете" + '\r' + '\n' +
            "3. ErrorImage: изображение, которое отображается, если основное изображение не удалось загрузить в PictureBox" + '\r' + '\n' +
            "4. Для установки изображения в PictureBox используется свойство SizeMode";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Свойства и методы элемента NumericUpDown " + '\r' + '\n' +
            "1. Для определения диапазона чисел для выбора NumericUpDown имеет два свойства: Minimum(задает минимальное число) и Maximum(задает максимальное число)." + '\r' + '\n' +
            "2. Само значение элемента хранится в свойстве Value:" + '\r' + '\n' +
            "3. Cвойство DecimalPlaces, которое указывает, сколько знаков после запятой должно отображаться.";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Свойства и методы элемента RadioButton " + '\r' + '\n' +
            "1. Чтобы установить у переключателя включенное состояние, надо присвоить его свойству Checked значение true." + '\r' + '\n' +
            "2. Для создания группы переключателей, из которых можно бы было выбирать, надо поместить несколько переключателей в какой-нибудь контейнер, например, в элементы GroupBox или Panel." + '\r' + '\n' +
            "События компонента RadioButton " + '\r' + '\n' +
            "1. Обрабатывая событие CheckedChanged, связав каждый переключатель группы с одним обработчиком данного события, мы сможем получить тот переключатель, который в данный момент выбран:";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Свойства и методы элемента DateTimePicker " + '\r' + '\n' +
            "1. Format: определяет формат отображения даты в элементе управления.Может принимать следующие значения:" + '\r' + '\n' +
            "2. CustomFormat: задает формат отображения даты, если для свойства Format установлено значение Custom" + '\r' + '\n' +
            "3. Value: определеяте текущее выбранное значение в DateTimePicker" + '\r' + '\n' +
            "4. Text: представляет тот текст, который отображается в элементе";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
