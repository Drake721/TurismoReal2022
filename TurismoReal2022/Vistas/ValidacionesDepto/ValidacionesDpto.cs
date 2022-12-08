using CapaEntidad;
using FluentValidation;
using System;
using System.Globalization;
using System.Windows.Controls;

namespace TurismoReal2022.Vistas.ValidacionesDepto
{
    internal class ValidacionesDpto : AbstractValidator<CE_Departamento>
    {
        public ValidacionesDpto()
        {
            RuleFor(d => d.NOMBRE_DPTO)
                .Cascade(CascadeMode.Stop).Length(8, 100)
                .WithMessage("El Nombre debe tener un largo entre 8 a 100 caracteres")
                .NotEmpty().WithMessage("Nombre no puede quedar vacio.");

            RuleFor(d => d.DIRECCION)
                .Cascade(CascadeMode.Stop).Length(3, 40)
                .WithMessage("La direccion deben tener un largo entre 8 a 20 caracteres")
                .NotEmpty().WithMessage("La direccion no puede quedar vacio.");

            RuleFor(d => d.TARIFA_DIARIA)
                .Cascade(CascadeMode.Stop)
                .GreaterThan(5)
                .LessThan(1000000000)
                .WithMessage("El campo no puede contener mas de 9 digitos")
                .NotEmpty().WithMessage("El valor de la tarifa no puede quedar vacio.");

            RuleFor(x => x.NRO_DPTO)
                .Cascade(CascadeMode.Stop)
                .GreaterThan(0)
                .LessThan(1000000000)
                .WithMessage("El campo no puede contener mas de 9 digitos")
                .NotEmpty().WithMessage("El Numero de departamento no puede quedar vacio.");

        }

    }
}
