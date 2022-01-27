package com.example.hypet;

import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.navigation.fragment.NavHostFragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;



import com.example.hypet.databinding.FragmentThirdBinding;

public class Descripcion extends Fragment {

    private FragmentThirdBinding binding;


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
            Bundle savedInstanceState) {



        View vista = inflater.inflate(R.layout.descripcion,container, false);

        return vista;

    }


    @Override
    public void onDestroyView() {
        super.onDestroyView();
        binding = null;
    }

}