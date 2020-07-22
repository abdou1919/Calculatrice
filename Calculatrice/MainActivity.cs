using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.Design.Widget;
using System;
using System.Threading;
using System.Linq.Expressions;

namespace Calculatrice
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText num1;
        EditText num2;
        decimal numero1;
        decimal numero2;
        decimal R;
        TextView res;
        
        Button addition, sustraction, mult,div;





        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            num1 = FindViewById<EditText>(Resource.Id.numero1);
            num2 = FindViewById<EditText>(Resource.Id.numero2);
            res = FindViewById<TextView>(Resource.Id.Resultat);


            addition = FindViewById<Button>(Resource.Id.addition);
            sustraction = FindViewById<Button>(Resource.Id.sustraction);
            mult = FindViewById<Button>(Resource.Id.mult);
            div = FindViewById<Button>(Resource.Id.div);
            addition.Click += (o, e) =>

            {
                try
                {
                    numero1 = decimal.Parse(num1.Text);
                    numero2 = decimal.Parse(num2.Text);
                    R = numero1 + numero2;

                    res.Text = R.ToString();
                
                }



               

                catch(Exception ex) {


                    res.Text = ex.Message;
                }
            };


            sustraction.Click += (o, e) =>

            {
                try {
                    numero1 = decimal.Parse(num1.Text);
                    numero2 = decimal.Parse(num2.Text);
                    R = numero1 - numero2;

                    res.Text = R.ToString();
                }



                catch(Exception ex)

                {

                    res.Text = ex.Message;
                }

            };



            mult.Click += (o, e) =>

            {

                try
                {
                    numero1 = decimal.Parse(num1.Text);
                    numero2 = decimal.Parse(num2.Text);
                    R = numero1 * numero2;

                    res.Text = R.ToString();

                }


                catch (Exception ex)

                {

                    res.Text = ex.Message;

                }

               

            };



            div.Click += (o, e) =>
             
           
                {
                    try

                    {

                numero1 = decimal.Parse(num1.Text);
                numero2 = decimal.Parse(num2.Text);
                R = numero1 / numero2;

                res.Text = R.ToString();
                    }

                    catch (Exception ex)

                    {
                        res.Text = ex.Message;


                    }

                };






        }
        //public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        //{
        //    Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        //    base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        //}
    }
}