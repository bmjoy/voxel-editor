﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMarker : MonoBehaviour, VoxelArrayEditor.Selectable
{
    private ObjectEntity _objectEntity;
    public ObjectEntity objectEntity
    {
        get
        {
            return _objectEntity;
        }
        set
        {
            if (_objectEntity != null)
                _objectEntity.marker = null;
            _objectEntity = value;
            if (_objectEntity != null)
                _objectEntity.marker = this;
        }
    }

    public bool addSelected { get; set; }
    public bool storedSelected { get; set; }
    public bool selected
    {
        get
        {
            return addSelected || storedSelected;
        }
    }

    public Bounds bounds
    {
        get
        {
            // TODO
            return new Bounds(transform.position, Vector3.zero);
        }
    }

    private Material[] storedMaterials;

    public void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            storedMaterials = (Material[])renderer.materials.Clone();
        }
    }

    public void SelectionStateUpdated()
    {
        UpdateMaterials();
    }

    public void UpdateMaterials()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            if (selected)
                SetAllMaterials(renderer, Voxel.selectedMaterial);
            else if (objectEntity != null && objectEntity.xRay)
                SetAllMaterials(renderer, Voxel.xRayMaterial);
            else
                renderer.materials = storedMaterials;
        }
    }

    private void SetAllMaterials(Renderer renderer, Material mat)
    {
        Material[] newMaterials = new Material[renderer.materials.Length];
        for (int i = 0; i < newMaterials.Length; i++)
            newMaterials[i] = mat;
        renderer.materials = newMaterials;
    }
}