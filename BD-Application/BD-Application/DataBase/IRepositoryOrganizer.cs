using BD_Application.Domain;

namespace BD_Application.DataBase {
    internal interface IRepositoryOrganizer {
        bool AddOrganizer(Organizer organizer);
        bool ChangeOrganizer(Organizer organizer);
        bool DeleteOrganizer(Organizer organizer);
    }
}
