using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoviesProject.Controls.RatingControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RatingSystem : StackLayout
    {
        public readonly BindableProperty RatingProperty =
            BindableProperty.Create(
                propertyName: nameof(Rating),
                returnType: typeof(int?),
                declaringType: typeof(RatingSystem),
                defaultValue: default(int),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: PropertyRatingUpdate
                );

        private static void PropertyRatingUpdate(BindableObject bindable, object oldValue, object newValue)
        {
            Debug.WriteLine($"The old rating is {oldValue} and the new rating is {newValue}.");
            var ratingSystem = (RatingSystem)bindable;
            if (ratingSystem != null)
                ratingSystem.UpdateRatingImages((int?)newValue);
        }

        public int? Rating
        {
            get => (int?)GetValue(RatingProperty);
            set
            {
                SetValue(RatingProperty, value);
            }
        }

        public RatingSystem()
        {
            InitializeComponent();
        }

        private void UpdateRatingImages(int? rating)
        {
            //Check if rating up of 1
            RatingOneImage.Source = GetRatingImage(rating, 1);
            //Check if rating up of 2
            RatingTwoImage.Source = GetRatingImage(rating, 2);
            //Check if rating up of 3
            RatingThreeImage.Source = GetRatingImage(rating, 3);
            //Check if rating up of 4
            RatingFourImage.Source = GetRatingImage(rating, 4);
            //Check if rating up of 5
            RatingFiveImage.Source = GetRatingImage(rating, 5);
        }
        private string GetRatingImage(int? orgRating, int rating)
        {
            //Return the name of image white or yellow by check string formate
            return $"ic_star{(rating > orgRating ? "White" : "Yellow")}";
        }
    }
}