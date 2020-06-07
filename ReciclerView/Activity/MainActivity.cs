using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.V7.Widget;
using ReciclerView.Helper;
using Android.Media;
using System;
using System.Collections.Generic;

namespace ReciclerView
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private RecyclerView recycler;
        private RecyclerViewAdapter adapter;
        private RecyclerView.LayoutManager layoutManager;
        private List<Datos> lstdata = new List<Datos>();


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            IniciarDatos();
            recycler = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            recycler.HasFixedSize = true;
            layoutManager = new LinearLayoutManager(this);
            recycler.SetLayoutManager(layoutManager);
            adapter = new RecyclerViewAdapter(lstdata);
            recycler.SetAdapter(adapter);
        }

        private void IniciarDatos()
        {
            lstdata.Add(new Datos() {ImageID=Resource.Drawable.kir,Descripcion="Kirby Tierno"});
            lstdata.Add(new Datos() { ImageID = Resource.Drawable.kirb, Descripcion = "Kirby Sentado de pana" });
            lstdata.Add(new Datos() { ImageID = Resource.Drawable.kirby, Descripcion = "Kirby Adorable" });
            lstdata.Add(new Datos() { ImageID = Resource.Drawable.kir, Descripcion = "Kirby Tierno" });
            lstdata.Add(new Datos() { ImageID = Resource.Drawable.kirb, Descripcion = "Kirby Sentado de pana" });
            lstdata.Add(new Datos() { ImageID = Resource.Drawable.kirby, Descripcion = "Kirby Adorable" });
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}