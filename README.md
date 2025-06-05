# 🏥 Sea Green Hospital – C# WinForms & SQL Server

Sea Green Hospital is a simple hospital management system built using **C# (WinForms)** and **SQL Server**.  
The system supports multiple user roles: **Secretary**, **Doctor**, and **Patient**, each with its own interface and features.

---

## 🔍 Summary

- 👩‍💼 Secretary: Manages doctors, departments (branches), appointments, and announcements  
- 👨‍⚕️ Doctor: Views assigned appointments and updates their information  
- 🧑‍🦽 Patient: Books appointments, views history, and updates personal data  
- 💾 SQL Server integrated for persistent data storage  
- 🎯 Simple user interfaces for learning and demonstration purposes

---

## 🗄️ Database Setup

To run this project, you should set up the SQL Server database first.

### 📁 Files:

> 💡 **Tip:** You can create a database with any name, but make sure to update the name in the connection string accordingly.


Inside the project folder, there is a folder named `db_create_to` which includes:
- Individual `.sql` files for each table (exported using **"Script Table as → CREATE To"**)
  - These files include the full `CREATE TABLE` statements for:
    - `Tbl_Branslar.sql`
    - `Tbl_Doktorlar.sql`
    - `Tbl_Duyurular.sql`
    - `Tbl_Hastalar.sql`
    - `Tbl_Randevular.sql`
    - `Tbl_Sekreter.sql`

---

## Project Overview
🖼️ Login Screen – Sea Green Hospital

<img src="https://github.com/user-attachments/assets/38777102-0467-43a6-b3e1-1f90f631350f" alt="Sea Green Hospital Giriş" width="500"/>

Users can select their role:

👨‍⚕️ Patient – Access patient-specific features.

🧑‍⚕️ Doctor – View and manage appointments.

👩‍💼 Secretary – Handle scheduling, doctors, branches, and announcements.

---

### 👩‍💼 Secretary Panel – Sea Green Hospital

---

🖼️ 1. Secretary Login Panel

<img src="https://github.com/user-attachments/assets/2489a125-46d2-4904-8937-b38caebae638" alt="Sekreter Giriş" width="400"/>

Secretaries log in using their National ID and password. Credentials are validated through the SQL database.

---

🖼️ 2. Secretary Details & Appointment Creation
<img src="https://github.com/user-attachments/assets/cb496b58-a134-4c5b-8b20-d60e45f0ac39" alt="Sekreter Detay" width="700"/>

The core screen for secretaries, which includes:

Secretary info display (ID, Name)

Appointment scheduling panel (date, time, doctor, patient TC)

Announcement creation section

Real-time branch & doctor lists

Quick access buttons to Doctor Panel, Branch Panel, Appointments, Announcements

---

🖼️ 3. Appointment List Panel

<img src="https://github.com/user-attachments/assets/a19423bd-9400-406a-97d9-4caf746ad8fb" alt="Appointment List" width="700"/>

Shows all scheduled appointments with details like:

Appointment ID, Date, Time

Department (Branch), Doctor

Appointment Status (✓ = taken)

Patient TC (National ID) and Complaint

---


🖼️ 4. Branch Management Panel

<img src="https://github.com/user-attachments/assets/c011f507-be7d-46b0-9660-341693404588" alt="Branch Panel" width="400"/>


Used for managing medical departments (branches):

➕ Add new branch

🗑️ Delete selected branch

🔁 Update branch information

---

🖼️ 5. Doctor Management Panel

<img src="https://github.com/user-attachments/assets/94be05ab-975b-444f-a020-8c45664914a7" alt="Doctor Panel" width="600"/>

Secretaries can manage doctor records:

Name, Surname, Department

National ID and Password

Add / Delete / Update functions

---

🖼️ 6. Announcements Panel

<img src="https://github.com/user-attachments/assets/4ed4ed54-915a-4ee2-b8d3-de3fb5c0312f" alt="Announcements" width="400"/>

A simple interface to display system-wide announcements created by the secretary.

---

### 👨‍⚕️ Doctor Panel

---

1. 🔹 Doctor Login Screen

<img src="https://github.com/user-attachments/assets/4a3186f4-d164-49e4-81c0-7d157d7da04f" alt="Doctor Login" width="400"/>

Doctors enter their National ID (TC) and password to access the system. Authentication is handled through the SQL Server database.

---

2. 🔹 Doctor Dashboard

<img src="https://github.com/user-attachments/assets/8ac9f841-5d3e-41d4-a380-98d9974d7abc" alt="Doctor Dashboard" width="700"/>

The dashboard provides doctors with a clear overview of their information and appointments:

Top-left shows the logged-in doctor's ID and name

Right side displays all assigned appointments

Left panel allows access to:

📋 Patient appointment details

✏️ Update personal info

📢 View announcements

🔚 Exit button

---

3. 🔹 Update Doctor Info

<img src="https://github.com/user-attachments/assets/8e0bfd32-e464-43ff-ac9d-9a1aaad83a42" alt="Update Doctor Info" width="300"/>

Doctors can update their personal information, including:

Name & Surname

TC Identity Number

Specialty (Branch)

Password

---

4. 🔹 Announcements Panel (Doctor View)
   
<img src="https://github.com/user-attachments/assets/1fadb2ff-ed11-4207-83d3-8ff7e2456a39" alt="Doctor Announcements" width="400"/>

Doctors can view all announcements created by the secretary. This ensures efficient communication about internal matters like meetings or schedule changes.

---

### 🧑‍🦽 Patient Panel

This section provides a detailed look at the **Patient Panel** of the Project Hospital system, where patients can log in, update their personal details, view appointment history, and schedule new appointments.

---

1. 🔹 Patient Login Screen


<img src="https://github.com/user-attachments/assets/44400136-1e1d-4224-8d08-bd0dd6a4fbf5" alt="Patient Login" width="400"/>

Patients enter their **National ID (TC Kimlik No)** and **password** to access the system.  
If the patient does not have an account, they can register by clicking the **"Üye Ol" (Sign Up)** link.

---

2. 🔹 Patient Dashboard

<img src="https://github.com/user-attachments/assets/93fb68dc-cf64-43b1-a957-ddec210a98e8" alt="Patient Dashboard" width="600"/>

The main dashboard provides patients with several essential functionalities:

#### 👤 Personal Info Panel  
Displays the patient's name and TC.

#### 🗓️ Appointment Panel  
Patients can:
- Choose a department (branch)
- Select a doctor
- Enter their complaint
- Click **"Randevu Al"** (Book Appointment)

#### 📜 Appointment History  
All past appointments are listed in a table, including:
- Date & Time
- Department & Doctor
- Complaint & Status

#### 📅 Active Appointments  
Shows upcoming appointments the patient has scheduled.

Patients can also click **"Bilgilerini Düzenle" (Edit Info)** to return to the update screen.

---

3. 🔹 Update Patient Information

<img src="https://github.com/user-attachments/assets/03afeee4-82f9-4977-9c88-d99a0371f82c" alt="Update Patient Info" width="350"/>

Patients can update their personal information via this screen, including:

- Name & Surname  
- National ID (TC)  
- Phone Number  
- Password  
- Gender

After filling in the fields, they can click the **Update (Güncelle)** button to save their information.




