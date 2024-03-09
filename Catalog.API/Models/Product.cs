﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Catalog.API.Models;

public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    [StringLength(80)]
    public string? Name { get; set; }

    [Required]
    [StringLength(100)]
    public string? Description { get; set; }

    [Required]
    [Column(TypeName = "decimal(10, 2)")]
    public decimal Price { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImageUrl { get; set; }
    public int Stock { get; set; }
    public DateTime CreatedAt { get; set; }
    public int CategoryId { get; set; }

    [JsonIgnore]
    public Category? Category { get; set; }
}
