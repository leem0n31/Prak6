using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;
 
    public string Email { get; set; } = null!;
 
    public string PasswordHash { get; set; } = null!;
    
    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();

    public virtual ICollection<Recommendation> Recommendations { get; set; } = new List<Recommendation>();

    public virtual ICollection<Review> ReviewDeletedByUsers { get; set; } = new List<Review>();

    public virtual ICollection<Review> ReviewUsers { get; set; } = new List<Review>();

    public virtual ICollection<Watchlist> Watchlists { get; set; } = new List<Watchlist>();
}




