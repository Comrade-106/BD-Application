using BD_Application.Domain;
using System.Collections.Generic;

namespace BD_Application.Repository {
    internal interface IRepositoryOrganizer {
        bool AddOrganizer(Organizer organizer);
        bool ChangeOrganizer(Organizer organizer);
        bool DeleteOrganizer(Organizer organizer);
        List<Organizer> GetAllOrganizers();
    }
}
