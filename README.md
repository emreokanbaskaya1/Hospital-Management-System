# 🏥 Project Hospital - C# WinForms

**Project Hospital** is a hospital patient management application developed using **C# Windows Forms** with a **SQL Server** database backend. The application allows users to add new patients, view patient lists, and manage basic hospital records through a simple UI.

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


