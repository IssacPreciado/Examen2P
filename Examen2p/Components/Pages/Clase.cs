using System.ComponentModel.DataAnnotations;

public class Producto
{
    [Required(ErrorMessage = "El número de inventario no debe estar vacío")]
    [Range(1, int.MaxValue, ErrorMessage = "Debe ser un número entero positivo y mayor que 0")]
    public int Id { get; set; }
    [Required(ErrorMessage = "El nombre no debe estar vacío")]
    public string? Nombre { get; set; }
    [Required(ErrorMessage = "Debes seleccionar un departamento")]
    public string? Departamentos { get; set; }
}