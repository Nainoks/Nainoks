package com.example.hypet;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class Adaptador extends RecyclerView.Adapter<Adaptador.ViewHolderDatos> implements  View.OnClickListener{

    ArrayList<String> data1, data2;
    int images[];
    Context context;

    private  View.OnClickListener listener;
    public Adaptador(Context ct, ArrayList<String> s1, ArrayList<String> s2, int img[]){
        context = ct;
        data1 = s1;
        data2 = s2;
        images = img;
    }

    @NonNull
    @Override
    public Adaptador.ViewHolderDatos onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        LayoutInflater inflater = LayoutInflater.from(context);
        View  view = inflater.inflate(R.layout.lista, parent,false);
        view.setOnClickListener(this::onClick);
        return new ViewHolderDatos(view);
    }

    @Override
    public void onBindViewHolder(@NonNull Adaptador.ViewHolderDatos holder, int position) {

        try{
            holder.texto1.setText(data1.get(position));
        }
        catch (Exception e){

        }

        try{
            holder.texto2.setText(data2.get(position));
        }
        catch (Exception e){

        }
        try{
            holder.imagen.setImageResource(images[position]);
        }
        catch (Exception e){

        }

    }

    @Override
    public int getItemCount() {
        return data1.size();
    }

    public  void SetOnClickListener(View.OnClickListener listener){
        this.listener = listener;
    }

    public  Lista Capturar(int num){
         Lista obj = new Lista(data1.get(num), data2.get(num),images[num]);


         return  obj;
    }

    @Override
    public void onClick(View v) {
        if (listener != null)
        {
            listener.onClick(v);
        }
    }

    public class ViewHolderDatos extends RecyclerView.ViewHolder {
        TextView texto1,texto2;
        ImageView imagen;
        public ViewHolderDatos(@NonNull View itemView) {
            super(itemView);
            texto1 = itemView.findViewById(R.id.Nombre);
            texto2 = itemView.findViewById(R.id.Descripcion);
            imagen = itemView.findViewById(R.id.Imagen);
        }
    }

}
