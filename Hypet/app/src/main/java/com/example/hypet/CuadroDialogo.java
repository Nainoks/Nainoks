package com.example.hypet;

import android.app.Dialog;
import android.content.Context;
import android.graphics.Color;
import android.graphics.drawable.ColorDrawable;
import android.view.View;
import android.view.Window;
import android.widget.Button;
import android.widget.EditText;

public class CuadroDialogo {

    public interface FinalCuadroDialgo{
        void ResultadoCuadroDialogo(String nombre, String descripcion);
    }

    private FinalCuadroDialgo interfaz;

    public CuadroDialogo(Context contexto, FinalCuadroDialgo actividad){
        interfaz = actividad;
        final Dialog dialogo = new Dialog(contexto);
        dialogo.requestWindowFeature(Window.FEATURE_NO_TITLE);

        dialogo.getWindow().setBackgroundDrawable(new ColorDrawable(Color.WHITE));
        dialogo.setContentView(R.layout.cuadro_dialogo);

        final EditText nombre = (EditText) dialogo.findViewById(R.id.editNombre);
        final EditText descripcion = (EditText) dialogo.findViewById(R.id.editDescripción);
        final Button  aceptar = (Button) dialogo.findViewById(R.id.botonAgregar);

        aceptar.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v) {
                interfaz.ResultadoCuadroDialogo(nombre.getText().toString(),descripcion.getText().toString());
                dialogo.dismiss();
            }
        });
        dialogo.show();
    }

}
