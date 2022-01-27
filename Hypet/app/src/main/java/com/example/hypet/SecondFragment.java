package com.example.hypet;

import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.navigation.fragment.NavHostFragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;


import com.example.hypet.databinding.FragmentSecondBinding;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Random;

public class SecondFragment extends Fragment implements  CuadroDialogo.FinalCuadroDialgo{
    private FragmentSecondBinding binding;
    RecyclerView gatos;
    private ArrayList<String> s1 = new ArrayList<String>();
    private ArrayList<String> s2 = new ArrayList<String>();
    private ArrayList<String> maullidos = new ArrayList<String>();

    private int[] fotos = new int[]{R.drawable.nessi,R.drawable.sushi,R.drawable.simba,R.drawable.yummi,R.drawable.colas,R.drawable.summy,R.drawable.maicra,R.drawable.snowy,R.drawable.munieca};

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
            Bundle savedInstanceState    ) {

        View vista = inflater.inflate(R.layout.fragment_second,container, false);
        gatos = (RecyclerView) vista.findViewById(R.id.recyclerView);
        gatos.setLayoutManager(new LinearLayoutManager(getContext()));

        Collections.addAll(s1, getResources().getStringArray(R.array.Gatos));
        Collections.addAll(s2, getResources().getStringArray(R.array.Descripción));
        Collections.addAll(maullidos, getResources().getStringArray(R.array.GatosRandom));

        Adaptador miAdaptador = new Adaptador(getContext(),s1,s2,fotos);
        miAdaptador.SetOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Lista miGato = miAdaptador.Capturar(gatos.getChildAdapterPosition(v));
                Random r = new Random();
                int i1 = r.nextInt(4 - 0) + 0;
                Toast.makeText(getActivity().getApplicationContext(), "" +maullidos.get(i1) , Toast.LENGTH_SHORT).show();

            }
        });
        gatos.setAdapter(miAdaptador);

        Button agregar = (Button) vista.findViewById(R.id.AgregarGato);
        agregar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                new CuadroDialogo(getContext(), SecondFragment.this::ResultadoCuadroDialogo);
            }
        });

        return vista;



    }



    @Override
    public void onDestroyView() {
        super.onDestroyView();
        binding = null;
    }

    @Override
    public void ResultadoCuadroDialogo(String nombre, String descripcion) {
        s1.add(nombre);
        s2.add(descripcion);
    }
}