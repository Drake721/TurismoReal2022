using FluentValidation;
using CapaEntidad;
using FluentValidation.Validators;

namespace TurismoReal2022.Vistas.ValidacionesUsuario
{
    public class RutHasta : AbstractValidator<CE_Usuario>
    {
        public RutHasta()
        {
            RuleFor(x => x.Rut)
                .Cascade(CascadeMode.Stop).Length(8, 14)
                .WithMessage("El Rut debe tener un largo entre 8 a 14 caracteres")
                .NotEmpty().WithMessage("Rut no puede quedar vacio.");

            RuleFor( x => x.Nombres)
                .Cascade(CascadeMode.Stop).Length(3, 40)
                .WithMessage("Los nombres deben tener un largo entre 3 a 40 caracteres")
                .NotEmpty().WithMessage("Los nombres no puede quedar vacio.");

            RuleFor(x => x.Apellidopaterno)
                .Cascade(CascadeMode.Stop).Length(3, 40)
                .WithMessage("El Apellido Paterno debe tener un largo entre 3 a 40 caracteres")
                .NotEmpty().WithMessage("El apellido no puede quedar vacio.");

            RuleFor(x => x.Apellidomaterno)
                .Cascade(CascadeMode.Stop).Length(3, 40)
                .WithMessage("El Apellido Materno debe tener un largo entre 3 a 40 caracteres")
                .NotEmpty().WithMessage("El apellido no puede quedar vacio.");

            RuleFor(x => x.Email)
                .Cascade(CascadeMode.Stop)
                .Length(11, 200).WithMessage("El Email debe tener al menos de 11 caracteres")
                .EmailAddress(EmailValidationMode.AspNetCoreCompatible).WithMessage("Email, no es un email valido")
                .NotEmpty().WithMessage("Correo no puede quedar vacio.");

            RuleFor(x => x.Clave)
                .Cascade(CascadeMode.Stop).Length(4, 14)
                .WithMessage("La clave debe contener al menos 4 caracteres")
                .NotEmpty().WithMessage("Clave no puede quedar vacio.");
            
        }

    }
}
