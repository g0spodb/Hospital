using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class DataAccess
    {
        public static List<patient> GetPatients()
        {
            List<patient> patients = new List<patient>(bdconnection.connection.patient);
            List<patient> patients1 = new List<patient>();
            foreach (var pat in patients)
            {
                patients1.Add(
                    new patient
                    {
                        id_pat = pat.id_pat,
                        FullName = pat.FullName,
                        sex = pat.sex,
                        birthDate = pat.birthDate,
                        diagnosis = pat.diagnosis,
                        way = pat.way,
                        arrival_date = pat.arrival_date,
                        other_description = pat.other_description
                    });
            }
            return patients1;
        }
        public static patient GetPatient(int id_pat)
        {
            List<patient> patients = GetPatients();
            var pat = patients.Where(p => p.id_pat == id_pat).FirstOrDefault();
            return pat;
        }
        public static List<discharge> GetDischarges()
        {
            List<discharge> discharges = new List<discharge>(bdconnection.connection.discharge);
            List<discharge> discharges1 = new List<discharge>();
            foreach (var dis in discharges1)
            {
                discharges1.Add(
                    new discharge
                    {
                        id_dis = dis.id_dis,
                        date_dis = dis.date_dis,
                        reason = dis.reason,
                        id_pat = dis.id_pat
                    });
            }
            return discharges1; 
        }
        public static discharge GetDischarge(int id_pat)
        {
            List<discharge> discharges = GetDischarges();
            var dis = discharges.Where(d => d.id_pat == id_pat).FirstOrDefault();
            return dis;
        }
        public static List<room> GetRooms()
        {
            List<room> rooms = new List<room>(bdconnection.connection.room);
            List<room> rooms1 = new List<room>();
            foreach (var room in rooms1)
            {
                rooms1.Add(
                    new room
                    {
                        id_room = room.id_room,
                        phone_number = room.phone_number
                    });
            }
            return rooms1;
        }
        public static List<log> GetLogs()
        {
            List<log> logs = new List<log>(bdconnection.connection.log);
            List<log> logs1 = new List<log>();
            foreach (var log in logs1)
            {
                logs1.Add(
                    new log
                    {
                        id = log.id,
                        id_pat = log.id_pat,
                        id_room = log.id_room,
                        trans_date = log.trans_date
                    });
            }
            return logs1;
        }
        public static log GetLog(int id)
        {
            List<log> logs = GetLogs();
            var log = logs.Where(l => l.id == id).FirstOrDefault();
            return log;
        }
        public static bool IsCorrectLogin(string login, string password)
        {
            ObservableCollection<employee> employees = new ObservableCollection<employee>(bdconnection.connection.employee);
            var currentEmployee = employees.Where(e => e.Login == login && e.Password == password).ToList();
            return currentEmployee.Count == 1;
        }
        public static bool RegistrationUser(employee Employee)
        {
            try
            {
                bdconnection.connection.employee.Add(Employee);
                bdconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    }
