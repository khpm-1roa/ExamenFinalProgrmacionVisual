﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KevinPillajoExamenWeb.Entitidades

public class Pareja

{

    public int ParejaId { get; set; }

    public string Nombre { get; set; }

    public Estudiante Estudiante { get; set; }

}