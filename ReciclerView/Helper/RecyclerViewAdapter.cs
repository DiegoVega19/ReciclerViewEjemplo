using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace ReciclerView.Helper
{
     class RecyclerViewHolder : RecyclerView.ViewHolder
    {
        public TextView txtHoras { get; set; }
        public TextView txtDia { get; set; }
        public TextView txtDescripcion { get; set; }
        public RecyclerViewHolder(View itemView): base(itemView)
        
        {
            txtHoras = itemView.FindViewById<TextView>(Resource.Id.txtHoras);
            txtDia = itemView.FindViewById<TextView>(Resource.Id.txtDias);
            txtDescripcion = itemView.FindViewById<TextView>(Resource.Id.descripciontexto);
        }
    }
    class RecyclerViewAdapter : RecyclerView.Adapter

    {
        private List<Datos> lstdata = new List<Datos>();

        public RecyclerViewAdapter(List<Datos> lstdata)
        {
            this.lstdata = lstdata;
        }

        public override int ItemCount
        {
            get
            {
                return lstdata.Count;
            }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            RecyclerViewHolder viewHolder = holder as RecyclerViewHolder;

            viewHolder.txtDescripcion.Text = lstdata[position].Descripcion;
            viewHolder.txtDia.Text = lstdata[position].Dias;
            viewHolder.txtHoras.Text = lstdata[position].Hora;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            LayoutInflater inflater = LayoutInflater.From(parent.Context);
            View itemview = inflater.Inflate(Resource.Layout.item, parent, false);
            return new RecyclerViewHolder(itemview);
        }

        
    }
}