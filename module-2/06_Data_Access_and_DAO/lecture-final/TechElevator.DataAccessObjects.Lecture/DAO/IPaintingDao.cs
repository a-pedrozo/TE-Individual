using System;
using System.Collections.Generic;
using System.Text;
using TechElevator.DataAccess.Models;

namespace TechElevator.DataAccess.DAO
{
    public interface IPaintingDao
    {
        // Get one
        Painting GetPaintingById(int paintingId);

        // Get all
        IList<Painting> GetAll();

        // Delete one
        bool DeletePaintingById(int id);

        // Add one
        Painting AddPainting(Painting newPainting);

        // Update one
        Painting UpdatePainting(Painting painting);
    }
}
