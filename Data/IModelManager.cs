﻿using System.Collections.Generic;
using DNP_Assignment2.Models;

namespace DNP_Assignment2.Data
{
    public interface IModelManager
    {
        string AddUser(User newUser);
        bool Login(User user);
        UserList GetAllUser();
        string UpdatePassword(User oldUser,User newUser);
        void RemoveUser(User user);
        string AddFamily(Family newFamily);
        FamilyList GetAllFamily();
        string UpdateFamily(Family oldFamily, Family newFamily);
        void RemoveFamily(Family family);
        string AddAdult(Adult newAdult);
        AdultList GetAllAdult();
        string AddChild(Child newChild);
        ChildList GetAllChild();
        string UpdatePerson(Person newPerson);
        void RemovePerson(Person person);
    }
}