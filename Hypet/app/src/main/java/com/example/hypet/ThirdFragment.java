package com.example.hypet;

import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.navigation.fragment.NavHostFragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;



import com.example.hypet.databinding.FragmentThirdBinding;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Random;

public class ThirdFragment extends Fragment implements  CuadroDialogo.FinalCuadroDialgo{
    private FragmentThirdBinding binding;
    RecyclerView perros;
    private ArrayList<String> s1;
    private ArrayList<String> s2;
    private ArrayList<String> ladridos;

    private int[] fotos = new int[]{R.drawable.bola,R.drawable.coca,R.drawable.cuca,R.drawable.mare,R.drawable.negra,R.drawable.solavino,R.drawable.wera,R.drawable.bombon,R.drawable.hachi,R.drawable.luna,R.drawable.nirvana};

    public  ThirdFragment() {
        s1 = new ArrayList<String>();
        s2 = new ArrayList<String>();
        ladridos = new ArrayList<String>();
    }

    @Override
    public View onCreateView(
            LayoutInflater inflater, ViewGroup container,
            Bundle savedInstanceState    ) {

        View vista = inflater.inflate(R.layout.fragment_third,container, false);
        perros = (RecyclerView) vista.findViewById(R.id.PerrosRecylcer);
        perros.setLayoutManager(new LinearLayoutManager(getContext()));
        ThirdFragment context = this;
        Collections.addAll(s1, getResources().getStringArray(R.array.Perros));
        Collections.addAll(s2, getResources().getStringArray(R.array.DescripciónPerro));
        Collections.addAll(ladridos, getResources().getStringArray(R.array.PerrosRandom));

        Adaptador miAdaptador = new Adaptador(getContext(),s1,s2,fotos);
        miAdaptador.SetOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Random r = new Random();
                int i1 = r.nextInt(4 - 0) + 0;
                Toast.makeText(getActivity().getApplicationContext(), "" +ladridos.get(i1) , Toast.LENGTH_SHORT).show();

            }
        });
        perros.setAdapter(miAdaptador);

        Button agregar = (Button) vista.findViewById(R.id.AgregarPerros);
        agregar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                new CuadroDialogo(getContext(), ThirdFragment.this::ResultadoCuadroDialogo);
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