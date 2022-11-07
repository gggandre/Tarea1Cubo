/* Importing the libraries that are going to be used in the code. */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// A01753176 Gilberto André García Gaytán
/* The class creates a cube using the vertices and triangles arrays */

// REPOSITORIO DE GITHUB DEL PROYECTO: 
// https://github.com/gggandre/Tarea1Cubo

public class A01753176_CuboTarea : MonoBehaviour
{
    /* Creating an array of 8 vertices. */
    private Vector3[] vertices ;
    /* Creating an array of 36 integers. */
    private int[] triangles    ;
    void Start()
    {
        /* Creating an array of 8 vertices. */
        vertices = new Vector3[8] ;
        /* Creating an array of 36 integers. */
        triangles = new int[36]   ;
        /* Getting the mesh component from the game object. */
        Mesh mesh = GetComponent<MeshFilter>().mesh ;
        /* Creating the vertices of the cube. */
        vertices[0] = new Vector3(0,0,0)   ;
        vertices[1] = new Vector3(1f,0,0)  ;
        vertices[2] = new Vector3(0,1f,0)  ;
        vertices[3] = new Vector3(1f,1f,0) ;
        vertices[4] = new Vector3(0,0,1)   ;
        vertices[5] = new Vector3(1f,0,1)  ;
        vertices[6] = new Vector3(0,1f,1)  ;
        vertices[7] = new Vector3(1f,1f,1) ;
        /* Creating the first triangle of the cube. */
        triangles[0] = 0 ;
        triangles[1] = 2 ;
        triangles[2] = 1 ;
        triangles[3] = 2 ;
        triangles[4] = 3 ;
        triangles[5] = 1 ;
        /* Creating the second triangle of the cube. */
        triangles[6]  =  4  ;
        triangles[7]  =  5  ;
        triangles[8]  =  6  ;
        triangles[9]  =  5  ;
        triangles[10] =  7  ;
        triangles[11] =  6  ;
        /* Creating the third triangle of the cube. */
        triangles[12] = 0 ;
        triangles[13] = 1 ;
        triangles[14] = 4 ;
        triangles[15] = 1 ;
        triangles[16] = 5 ;
        triangles[17] = 4 ;
        /* Creating the fourth triangle of the cube. */
        triangles[18] = 2 ;
        triangles[19] = 6 ;
        triangles[20] = 3 ;
        triangles[21] = 6 ;
        triangles[22] = 7 ;
        triangles[23] = 3 ;
        /* Creating the 5th triangle of the cube. */
        triangles[24] = 1 ;
        triangles[25] = 3 ;
        triangles[26] = 5 ;
        triangles[27] = 3 ;
        triangles[28] = 7 ;
        triangles[29] = 5 ;
        /* Creating the 6th triangle of the cube. */
        triangles[30] = 0 ;
        triangles[31] = 4 ;
        triangles[32] = 2 ;
        triangles[33] = 4 ;
        triangles[34] = 6 ;
        triangles[35] = 2 ;
        /* Assigning the vertices to the mesh. */
        mesh.vertices = vertices   ;
        /* Assigning the triangles to the mesh. */
        mesh.triangles = triangles ;
        /* Recalculating the normals of the mesh. */
        mesh.RecalculateNormals()  ;
    }
}
