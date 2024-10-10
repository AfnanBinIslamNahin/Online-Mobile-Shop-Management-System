# Online-Mobile-Shop-Management-System

This project implements a Online Mobile shop Management  System.   The Online Mobile Shop Management System is designed to efficiently manage an e-commerce mobile phone business, catering to two user types: Admin and Customer.
# CASE STUDY:
The Mobile Phone Management System (MPMS) is designed to streamline the operations of a mobile phone retail and service company by managing key processes such as mobile phone orders, payments, services, reviews, and administrative functions. The system involves several entities: Admin, Customer, Order Request, Payment, Mobile Service, Review, Add Phone, and Service Center, each of which plays a distinct role in ensuring the smooth functioning of the system. The Admin entity handles system management tasks. Admins are responsible for maintaining customer records, managing mobile phone inventory, and overseeing service center operations. They have  the ability to add new phones, track payments, and ensure customer service requests are handled effectively. Each admin's personal details, such as email, password, name, and address, are securely stored within the system. The Customer entity represents the users of the system, each of whom has a unique profile with attributes like email, password, name, and address. Customers can browse available mobile phones, place orders, request services, make payments, and leave reviews. Their interactions with the system are closely tied to the Order Request, Payment, Mobile Service, and Review entities. When a customer places an order, the details are recorded in the Order Request entity. This includes the phone's specifications such as brand, model, RAM, storage, and color, along with the customer’s email for tracking purposes. Once the order is confirmed, the payment process begins, and the Payment entity records the transaction. Information such as payment method, date, customer address, and the phone model are stored for future reference and to ensure a smooth transaction process. In cases where customers face issues with their mobile phones, they can raise a service request, which is logged in the Mobile Service entity. This entity captures details about the phone's brand, model, and the specific issue reported, linking the request to the customer’s profile. The Service Center entity plays a role in resolving these requests by assigning a technician, who then logs the solution once the issue is resolved. After receiving a product or service, customers have the opportunity to leave feedback in the Review entity. This feedback, which includes details about the phone model and a message from the customer, helps the company evaluate the quality of its products and services, ultimately contributing to continuous improvement. The Add Phone entity serves as the system's inventory database, containing detailed records of available mobile phones, including specifications such as serial number, company, model, RAM, storage, display, camera features, and price. Admins regularly update this entity to ensure customers have access to accurate information when placing orders. Overall, the Mobile Phone Management System offers a comprehensive platform for managing all aspects of mobile phone retail and services. The interaction between entities ensures efficient data flow, allowing customers to easily place orders, make payments, and request services, while admins oversee the entire process. By automating and organizing these operations, the system enhances both customer satisfaction and operational efficiency.

# Schema Diagram :

<img width="645" alt="diagram" src="https://github.com/user-attachments/assets/aa4fc611-e191-4d7f-a644-c1a3598f9af3">

# Navigation Diagram :

<img width="476" alt="Screenshot 2024-09-26 at 3 42 43 PM" src="https://github.com/user-attachments/assets/2f19da00-7a07-4f80-b5a8-f2a1164f3743">


# SQL Query :
#### users table
```bash
 CREATE TABLE [dbo].[users] (
    [f_name]   VARCHAR (50) NULL,
    [l_name]   VARCHAR (50) NULL,
    [date]     VARCHAR (50) NULL,
    [gender]   VARCHAR (50) NULL,
    [address]  VARCHAR (50) NULL,
    [email]    VARCHAR (50) NOT NULL,
    [password] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([email] ASC)
);
```
#### service center table
```bash
CREATE TABLE [dbo].[service_center] (
    [technician_Id] INT          NOT NULL,
    [service_id]    VARCHAR (50) NULL,
    [solution]      VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([technician_Id] ASC)
);
```
#### review table
```bash
CREATE TABLE [dbo].[review] (
    [review_id]      INT          NOT NULL,
    [customer_email] VARCHAR (50) NULL,
    [message]        VARCHAR (50) NULL,
    [company]        VARCHAR (50) NULL,
    [model]          VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([review_id] ASC), 
    CONSTRAINT [FK_review_ToTable] FOREIGN KEY ([customer_email]) REFERENCES [users]([email])
);
```
#### payment table
```bash
CREATE TABLE [dbo].[payment] (
    [payment_Id]     INT          NOT NULL,
    [customer_email] VARCHAR (50) NULL,
    [payment_date]   VARCHAR (50) NULL,
    [payment_method] VARCHAR (50) NULL,
    [address]        VARCHAR (50) NULL,
    [company]        VARCHAR (50) NULL,
    [model]          VARCHAR (50) NULL,
    [price]          VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([payment_Id] ASC), 
    CONSTRAINT [FK_payment_ToTable] FOREIGN KEY ([customer_email]) REFERENCES [users]([email])
);
```
#### order request table
```bash
CREATE TABLE [dbo].[order_request] (
    [order_Id]          INT          NOT NULL,
    [brand]             VARCHAR (50) NULL,
    [model]             VARCHAR (50) NULL,
    [ram]               VARCHAR (50) NULL,
    [internal_storage]  VARCHAR (50) NULL,
    [color]             VARCHAR (50) NULL,
    [expandable_memory] VARCHAR (50) NULL,
    [email]             VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([order_Id] ASC), 
    CONSTRAINT [FK_order_request_ToTable] FOREIGN KEY ([email]) REFERENCES [users]([email])
);
```
#### mobile service table
```bash
CREATE TABLE [dbo].[mobile_service] (
    [service_Id] INT          NOT NULL,
    [brand]      VARCHAR (50) NULL,
    [model]      VARCHAR (50) NULL,
    [issue]      VARCHAR (50) NULL,
    [picture]    IMAGE        NULL,
    [email]      VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([service_Id] ASC), 
    CONSTRAINT [FK_mobile_service_ToTable] FOREIGN KEY ([email]) REFERENCES [users]([email])
);
```
#### admin table
```bash
CREATE TABLE [dbo].[admin] (
    [full_name] VARCHAR (50) NULL,
    [address]   VARCHAR (50) NULL,
    [gender]    VARCHAR (50) NULL,
    [email]     VARCHAR (50) NOT NULL,
    [password]  VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([email] ASC)
);
```
#### add phone table
```bash
CREATE TABLE [dbo].[add_phone] (
    [company]            VARCHAR (50) NULL,
    [model ]             VARCHAR (50) NULL,
    [ram]                VARCHAR (50) NULL,
    [internal_storage]   VARCHAR (50) NULL,
    [expandable_memory]  VARCHAR (50) NULL,
    [display]            VARCHAR (50) NULL,
    [rear_camera]        VARCHAR (50) NULL,
    [front_camera]       VARCHAR (50) NULL,
    [fingerprint_sensor] VARCHAR (50) NULL,
    [battery]            VARCHAR (50) NULL,
    [serial_number]      INT          NOT NULL,
    [network_type]       VARCHAR (50) NULL,
    [color_available]    VARCHAR (50) NULL,
    [price]              VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([serial_number] ASC));
```
### Screenshots

# Login Page:
<img width="500" alt="p1" src="https://github.com/user-attachments/assets/57456017-6a69-482d-bd44-745145e5525d">

# Customer Signup Page:
<img width="476" alt="p18" src="https://github.com/user-attachments/assets/7265dec4-b22a-4b98-8efb-64fb335a3e4d">

# Admin Signup page:
<img width="473" alt="p19" src="https://github.com/user-attachments/assets/90e6eb2e-f491-4e42-beb8-78d61bddccd4">

# Admin profile:
<img width="749" alt="p2" src="https://github.com/user-attachments/assets/5cf6a0a2-f70c-4b8d-bca7-65cc8ffab6d3">

# Admin Add Mobile Page:
<img width="812" alt="p3" src="https://github.com/user-attachments/assets/adf1617b-12f0-4d92-9f79-37c4e2caa047">

# Admin Stock page:
<img width="866" alt="p4" src="https://github.com/user-attachments/assets/593747e8-effa-4428-bebf-af4a402c8868">

# Admin User Information Page:
<img width="889" alt="p5" src="https://github.com/user-attachments/assets/a4922743-2a83-4d3a-b073-ab86c482f85d">

# Customer record page:
<img width="643" alt="p6" src="https://github.com/user-attachments/assets/8bc9fae8-b2b6-40bb-b315-cf2fa3b1f93a">

# Admin order request page:
<img width="770" alt="p7" src="https://github.com/user-attachments/assets/7c92b7cf-988b-4aa2-8681-3219d7af770b">

# Admin review page:
<img width="789" alt="p8" src="https://github.com/user-attachments/assets/5bddd91b-372e-48a9-aaae-60abd7d9c24a">

# Service center page:
<img width="748" alt="p9" src="https://github.com/user-attachments/assets/a365e835-a1cc-484c-8e8c-364825da86ef">

# Customer profile:
<img width="736" alt="p11" src="https://github.com/user-attachments/assets/d90e43a7-9bdd-4032-ba0c-a1e3a5323cd9">

# Mobile search page:
<img width="868" alt="p12" src="https://github.com/user-attachments/assets/d187cf6c-eccb-4ea8-b8e1-c344c46a040d">

# Mobile purchase page:
<img width="779" alt="p13" src="https://github.com/user-attachments/assets/deeb106f-2400-4e61-a832-6be7012205f7">

# Customer mobile service page:
<img width="767" alt="p14" src="https://github.com/user-attachments/assets/8cc04766-7714-4739-9be1-763fa5e05f77">

# Service center page:
<img width="640" alt="p15" src="https://github.com/user-attachments/assets/e13fe227-3638-4401-8e0a-2107a2efa0d3">

# Order request page:
<img width="746" alt="p16" src="https://github.com/user-attachments/assets/d43bb3e7-5e53-4887-b0b8-fafa8bb6c316">

# Review page:
<img width="641" alt="p17" src="https://github.com/user-attachments/assets/28d33af1-3eca-4dd7-a8f1-0d55d48b4e9e">







