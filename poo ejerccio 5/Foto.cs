using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ejerccio_5
{
    class Foto
    {
        int Id;
        float Tamaño;
        int fechaCreacion;
        string comentario;

        public Foto(int id, float tamaño, int fechaCreacion, string comentario)
        {
            Id = id;
            Tamaño = tamaño;
            this.fechaCreacion = fechaCreacion;
            this.comentario = comentario;
        }

        public int Id1 { get => Id; set => Id = value; }
        public float Tamaño1 { get => Tamaño; set => Tamaño = value; }
        public int FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public string Comentario { get => comentario; set => comentario = value; }

        public override string ToString()
        {
            return "Id: " + Id + "\n tamaño: " + Tamaño + "\n Fecha de creacion" + FechaCreacion + "\n comentario" + comentario;
        }

        
    }
}
