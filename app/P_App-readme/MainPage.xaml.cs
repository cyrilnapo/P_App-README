﻿using System.Collections.ObjectModel;
using VersOne.Epub;
using HtmlAgilityPack;


namespace P_App_readme
{
    public class Book
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Book> books = new ObservableCollection<Book>();



        public MainPage()
        {
            InitializeComponent();

            EpubBook book = EpubReader.ReadBook("DickensCharles-AChristmasCarol.epub");


            books.Add(new Book { Image = "hpbook.jpg", Title = $"{book.Title}", Author = "J.K. Rowling" });
            books.Add(new Book { Image = "hpbook.jpg", Title = "Harry Potter et la Chambre des Secrets", Author = "J.K. Rowling" });
            books.Add(new Book { Image = "hpbook.jpg", Title = "Harry Potter et le Prisonnier d'Azkaban", Author = "J.K. Rowling" });

            Books = books;

            BindingContext = this;
        }

        public ObservableCollection<Book> Books { get; set; }
    }
}