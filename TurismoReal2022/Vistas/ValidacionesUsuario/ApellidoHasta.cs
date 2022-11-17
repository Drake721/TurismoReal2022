﻿using System;
using System.Globalization;
using System.Windows.Controls;

namespace TurismoReal2022.Vistas.ValidacionesUsuario
{
    public class ApellidoHasta : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                var apellido = Convert.ToString(value);

                if (apellido != null && apellido != string.Empty)
                {
                    if (apellido.Length >= 200)
                    {
                        return new ValidationResult(false, "El apellido no puede superar los 40 caracteres");
                    }
                }
                else
                {
                    return new ValidationResult(false, "El apellido es requerido");
                }
                return ValidationResult.ValidResult;
            }
            catch (Exception)
            {
                return new ValidationResult(false, "Algo anda mal");
            }
        }
    }
}
