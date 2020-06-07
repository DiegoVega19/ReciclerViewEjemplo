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
        public ImageView imageView { get; set; }
        public TextView txtDescripcion { get; set; }
        public RecyclerViewHolder(View itemView): base(itemView)
        {
            imageView = itemView.FindViewById<ImageView>(Resource.Id.imageView1);
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
            viewHolder.imageView.SetImageResource(lstdata[position].ImageID);
            viewHolder.txtDescripcion.Text = lstdata[position].Descripcion;
            viewHolder.txtDescripcion.Text = lstdata[position].Descripcion;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            LayoutInflater inflater = LayoutInflater.From(parent.Context);
            View itemview = inflater.Inflate(Resource.Layout.item, parent, false);
            return new RecyclerViewHolder(itemview);
        }

        
    }
}