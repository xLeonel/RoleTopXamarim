﻿using RoleTopMobile.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RoleTopMobile.Models
{
    public class Estadio
    {
<<<<<<< HEAD
=======

>>>>>>> db9868da8da6c1d8ef0ac30b947bd759b234245e
        public ImageSource imgSourceEstadio
        {
            get
            {
                try
                {
                    return Utils.getImageSourceFromByteArray(foto);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public int id { get; set; }
        public int evento { get; set; }
        public string nome { get; set; }
        public byte[] foto { get; set; }
        public int latitude { get; set; }
        public int longitude { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public object eventoNavigation { get; set; }
        public ImageSource fotoConvertida { get; set; }
        
    }
}

