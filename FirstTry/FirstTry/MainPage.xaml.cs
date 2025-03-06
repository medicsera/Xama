using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstTry
{
    public partial class MainPage : ContentPage
    {
        Button button;
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            /*StackLayout stack = new StackLayout();

            Label label = new Label();
            label.Text = "Hello world";
            label.HorizontalOptions = LayoutOptions.Center;
            label.TextTransform = TextTransform.Uppercase;
            label.FontSize = 25;

            button = new Button();
            button.Text = "Нажми на меня";
            button.FontSize = 20;
            button.TextColor = Color.Blue;
            button.Clicked += button_click;


            stack.Children.Add(label);
            stack.Children.Add(button);

            Content = stack;*/

         
        }
/*
        private async void button_click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryname.Text))
                errortext.Text = "Имя не указано";
            else if (string.IsNullOrEmpty(entryemail.Text))
                errortext.Text = "Почта не указана";
            else if (string.IsNullOrEmpty(entrypassword.Text))
                errortext.Text = "Пароль не указана";
            else if (!checkbox.IsChecked)
                errortext.Text = "Подтвердите данные";
            else
            {
                errortext.Text = "";
                buttonsend.Text = "Done";
                buttonsend.TextColor = Color.GreenYellow;
                await DisplayAlert("Данный из формы", "Все данные получено", "Закрыть");
            }
        }*/
    }
}
