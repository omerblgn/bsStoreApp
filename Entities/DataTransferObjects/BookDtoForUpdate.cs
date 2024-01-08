using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public record BookDtoForUpdate : BookDtoForManipulation
    {
        [Required]
        public int Id { get; init; }

        [Required(ErrorMessage = "Category ID is required field.")]
        public int CategoryId { get; init; }
    }
}