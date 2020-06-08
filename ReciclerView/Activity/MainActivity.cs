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
            layoutManager = new GridLayoutManager(this, 1, GridLayoutManager.Horizontal, false);
            recycler.SetLayoutManager(layoutManager);
          
            adapter = new RecyclerViewAdapter(lstdata);
            recycler.SetAdapter(adapter);
        }

        private void IniciarDatos()
        {
            lstdata.Add(new Datos() {ImageID=1,Descripcion="Matematica",Dias= "Lunes - Viernes",Hora= "8:00Am - 10:00Am" });
            lstdata.Add(new Datos() { ImageID = 2, Descripcion = "P00", Dias = "Sabado - Domingo", Hora = "9:00Am - 12:00Am" });
            lstdata.Add(new Datos() { ImageID =3, Descripcion = "Bases de datos", Dias = "Lunes - Viernes", Hora = "8:00Am - 10:00Am" });
            lstdata.Add(new Datos() { ImageID = 4, Descripcion = "Estructura de datos", Dias = "Sabado - Domingo", Hora = "9:00Am - 12:00Am" });
            lstdata.Add(new Datos() { ImageID =5, Descripcion = "Investigacion Aplicada", Dias = "Lunes - Viernes", Hora = "8:00Am - 10:00Am" });
            lstdata.Add(new Datos() { ImageID = 6, Descripcion = "Estadistica", Dias = "Sabado - Domingo", Hora = "9:00Am - 12:00Am" });
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}