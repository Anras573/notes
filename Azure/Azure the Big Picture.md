# Azure: the Big Picture

## Content

1. Overview
2. Computing
   1. Virtual Machines
   2. Containers
   3. Cloud Services
   4. Web Apps
   5. Azure App Services
   6. Containers and Micro Services
3. Data Storage
   1. Data
   2. Types of Data Storage
   3. Microsoft Azure PaaS Data Storage
   4. Microsoft Azure IaaS Data Storage
   5. Data Lakes
4. Messaging
   1. Azure Service Bus
   2. Azure Storage Queues
5. Data Processing
   1. What is Data Processing
   2. Azure SQL Data Warehouse
   3. HDInsight
   4. Azure Data Lake Analytics
   5. Stream Analytics
   6. Machine Learning
6. Networking
   1. Virtual Networks
   2. Hybrid Network Solutions
   3. Application Networking
7. Services
   1. App Services
      1. API Apps
      2. Mobile Apps
      3. Logic Apps
   2. API Management
8. Active Directory
   1. Azure Active Directory vs. Active Directory
   2. Azure Active Directory Scenarios
   3. Accessing Applications
9. Management
   1. Managing Azure Applications
   2. Azure Accounts and Subscriptions
   3. Managing resources
   4. Resource Manager
   5. Azure Automation
   6. Familiar Tools for Managing VMs
   7. Monitoring Your Cloud Solutions
10. Other Services
    1. Media Services
    2. Remote App
    3. Recovery Services
    4. Scheduling Work
11. Learning Check

## Overview

3 types of cloud offerings.

* IaaS - Infrastructure as a Service  
   Virtual machines and containers. Leveraging the hardware of the datacenter.
* PaaS - Platform as a Service  
   Cloud services and web apps. Not interested in the underlying infrastructure or the operating system.
* SaaS - Software as a Service  
   Things like Exchange, SharePoint or Office365. Often API's or services.

The 3 offerings can be mixed and matched.

## Computing

The resources than run your code.

* CPU
* Memory
* Disk space

The foundation of all of Azure. Focus is on scalability and manageability.

### Virtual Machines

* Linux or Windows
* Prebuildt images
* Variying sizes
* Premium storage
* You manage the operating system

### Containers

* Lightweight application hosts
* Chain images together
* Linux now, with Windows on the way
* Docker client support on Windows

### Cloud Services

* Web/worker roles
* Package application code
* Declared target operating system
* Azure Service Fabric managed

### Web Apps

* Web application code
* IIS hosting at scale
* Source Control integration for CI
* Web Jobs for background processing

### Azure App Services

* Web Apps
* API Apps
* Mobile Apps
* Logic Apps

### Containers and Micro Services

* For complex systems
* Highly automatable
* Repeatable deployments

## Data Storage

Data is a large part of cloud solutions. Azure provides a huge variety of PaaS and IaaS solutions. Build with scale and resilience in mind.

### Data

* Data is expanding at a rapid rate
* Various types and uses of data
* Storage at global scale
* Many processing options

### Types of Data Storage

* Relation  
   SQL database
* Key/Value  
   Primary lookup key, where the value can be of varying types of data, like a string or an object with a variety of properties.
* Blob  
   Files, like images, movies, virtual hard drives or documents.
* Document  
   NoSQL. JSON document with the ability to query the document.
* Graph  
   Set of nodes and their relationships.
* Column  
   Data in a series of columns.

### Microsoft Azure PaaS Data Storage

* Azure SQL Database/MySQL  
   Buildt specifically for Azure. Scalability and resilience. You provision the service and the database.
* Storage Tables/Redis  
   Key/Value store. Features Redis Cache and Azure Caching.
* Storage Blobs/File Services  
   File Storage. Includes a file system for easier browsing of files.
* Document DB/RavenHQ/MongoDB  
   Scalability and resilience. You provision the service and the database.

### Microsoft Azure IaaS Data Storage

Virtual machines where you'll install the data storage provider that you'll need.

* Relational  
   SQL Server, Oracle DB, My SQL, PostgreSQL, and more.
* Key/Value  
   Redis, Memcached, Riak, and more.
* Graph  
   Neo4j, Dex, OrientDB, InfiniteGraph, AllegroGraph, and more.
* Document  
   MongoDB, CouchDB, ArangoDB, and more.
* Column  
   Casandra, HBase

### Data Lakes

* Massively scalable storage
* Store data in native formats
* HDFS compatible (Hadoo File System)
* High throughput

## Messaging

Different messaging options. Service Bus is the core messaging offering. Multiple messaging patterns. Messages are sets of data.

* Global, scalable, internet systems
* Communication is paramount
* Inter-system, user notification, IoT

### Azure Service Bus

* Relay  
  Connecting applications across complicated networks. Realtime connectivity.
* Brokered Messaging  
  * Queues  
    Producers enqueue messages and consumers process them as they become available.
  * Topics  
    Producers attach topics to messages and the consumers only get the messages that they're interested in.
* Notification Hubs  
  Notifications to mobile devices or browsers.
  * Tags/Filters allow for customization
  * Scales to millions of devices
  * Raw, native, or template notifications
* Event Hubs  
   Built to handle massive amount of data.

### Azure Storage Queues

* Original Queue offering in Azure
* Based on Azure Storage model
* HTTP/SDK support only

[More information (Storage queues and Service Bus queues - compared and contrasted)](https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-azure-and-service-bus-queues-compared-contrasted)

## Data Processing

Have a need to process vast set of data. Analytics that can scale. Different types of data need different types of tools. 

### What is Data Processing

* Analytics
* Decision Making
* Prediction
* Moving and transforming

### Azure SQL Data Warehouse

* Built for the cloud
* Scale compute and storage seperately

### HDInsight

* Hadoop services running in Azure
* Integrates with Excel
* Coordinate with on-premises clusters
* Full suite of Hadoop services

### Azure Data Lake Analytics

Large set of data across different storage providers. Process the data and analyze it.

* Leveraging U-SQL and C#

### Stream Analytics

Working with realtime data.

### Machine Learning

Process data and come up with a predictive model. What can we predict? Take data and run it through the model.

### Data Factory

ETL (extract-transform-load) tool built for the cloud. Run data through a pipeline, generates data that we can store. Can be scaled.

## Networking

* Networking Azure resources  
  Make your resources able to talk to each other.
* Connecting Azure to your datacenter
* Application networking

### Virtual Networks

Large amount of control over the network

* Virtual machines and  services
* Manage subnets
* You can bring your own DNS, AD, etc.

### Hybrid Network Solutions

Some run in the cloud, and in your datacenter

* Hybrid Connections  
  Install a proxy in your datacenter that creates a bridge to Azure. Used for particular resources.
* Site-to-site or Point-to-site VPN  
  Point-to-site is used for a whole server. Site-to-site is used for an entire datacenter.
* ExpressRoute  
  Direct connection to Azure.

### Application Networking

* CDN  
  Content close to customers. Caches data first time it's requested.
* Trafic Manager  
  Setup rules for which datacenter responds to the request. Intelligent loadbalancer. Can be used for fault tolerance.
* Azure DNS

## Services

Services are a key part of today's solutions. Different options based on type of service. API management for advanced options.

* Azure App Services  
  Web services, HTTP services, houses your applications data, logic and rules.
* Azure API Management

### App Services

* Web Apps
* API Apps
* Mobile Apps
* Logic Apps

#### API Apps

* Build and expose rich HTTP APIs
* Catalog of APIs for internal or external use
* Metadata support for tooling
* Leverage common services from App Services

#### Mobile Apps

* Data storage and push notifications
* Rich client SDKs for multiple platforms
* Offline support
* Leverage common services from App Services

#### Logic Apps

* Workflow application logic
* Consume API Apps (yours and others)
* Web designer in the management portal
* Leverage common services from App Services

### API Management

* API facade/aggregation
* Monitoring, metrics, and quotas
* Authentication/authorization
* Documentation and developer portal

## Active Directory

Manage cloud identities. Integrate with Office 365 or Active Directory. Modern solutions for B2C and B2B.

* Identity and directory services in the cloud
* Support for web and cloud applications
* Integrates with your existing directory

Also supports multi-factor authentication.

### Azure Active Directory vs. Active Directory

* Active Directory
  * Identity management on-premises
  * Single sign on for Windows apps
  * Federation for partner organizations
* Azure Active Directory
  * Identity management for the cloud
  * Single sign on for SaaS apps
  * Social identity provider support for B2C
  * B2B partnerships

### Azure Active Directory Scenarios

Sync multiple directories in the cloud

* Azure Active Directoru <-> Office 365 <-> on-premise Active Directory
* Azure Active Directory <-> on-premise Active Directory
* Azure Active Directory <-> Office 365

### Accessing Applications

* Web Authentication
  Being able to use your Active Directory for authentication in your own web apps, SharePoint, or Exchange services.
* Social Providers
  Let B2C Directory handle the login with social providers.
* Application Proxy
  Connect users to connect to your data center applications.

## Management

Management includes operations and monitoring. All operations happen through an API. Azure services can be managed as part of your overall system.

### Managing Azure Applications

* Provision, removing, and managing resources
* Automating processes
* Monitoring infrastructure and applications

### Azure Accounts and Subscriptions

When you setup an account, you can setup one or more subscriptions, and all of the resources inside of it. A subscription has an admin and can have a co-admin. An account have an account manager.

### Managing resources

* Managemnt REST API
  * PowerShell
  * CLI
  * Visual Studio
  * Portal
  * System Center
  * Custom tools

### Resource Manager

Allows you to describe the entire application via a template, and Azure wil provision all the resources tha you'll need.

### Azure Automation

* Runbooks for management tasks
* PowerShell Scripts
* Storage of connections, certifications etc.
* Run on a schedule
* Link Runbooks

### Familiar Tools for Managing VMs

* Management
  * Chef
  * Puppet
  * PowerShell DSC
  * Octopus Deploy
* Antimalware/Antivirus
  * McAfee
  * Microsoft
  * Symantec
  * Trend Micro

### Monitoring Your Cloud Solutions

* System Center Operations Manager
* Azure Specific Solutions
  * Operational Insights
  * Application Insights
* Third Party Monitoring/Management

## Other Services

### Media Services

Take media files like video and audio, encode them and stream them to a variety of different devices.

### Remote App

Host your applications in Azure and allow clients to connect and run them in the cloud.

### Recovery Services

Backup your applications in Azure.

### Scheduling Work

* Batch Services
  * For cluster scale work scheduling
  * Manages work queue, dispatcher and monitoring
  * VM instance management and retry
* Azure Scheduler
  * For individual task work scheduling
  * HTTP endpoints
  * Azure Storage Queues
  * Simple or complex schedules

## Learning Check

Which compute offering does NOT provide automatic healing of applications?  
> Virtual Machines

What is the underlying layer for all management tools?  
> The Azure Management REST API

Which of the following is a feature of API Management?  
> Authorization. Monitoring and metrics. API aggregation. Quotas.

Which network offering enables a connection from Azure to a database or web service?  
> Hybrid Connections

Which of the following is NOT a benefit of cloud computing?  
> You maintain complete control over hardware

Which of the following is NOT currently an Azure Active Directory feature?  
> Fingerprint login

Which of the following is NOT a feature of Data Lakes?  
> Available for columns and key/value data stores only.

Which Service Bus offering provides push notification services for mobile devices?  
> Notification Hubs

What is HDInsight?  
> Microsoft's cloud offering of the open source Apache Hadoop services

Which analysis offering enables real time processing on Event Hubs data?  
>Stream Analytics

Which of the following is NOT an Azure service for building services?
> Xbox Apps

Which networking option provides the best performance and stability when connecting to your datacenter?
> Express Route

Which of the following offerings allows you to make and use a predictive model?
> Machine Learning

Which compute offering requires you to package your code a certain way?
> Cloud Services

Which of the following datastores are available as PaaS offerings in Azure?
> Document database. Key/Value store. Relational database. Blob storage.

Which of the following can manage Azure resources?
> The Azure Management Portal. Visual Studio. PowerShell. Systems Center Operations Manager.

Which of the following are supported Azure Active Directory configurations?
> Directory synchronized with on-premises Windows Active Directory. Standalone directory.Shared directory with Office 365.

What is one difference between IaaS and PaaS?
> With IaaS you still manage a lot of the core operating system services and patches.

Which of the following is an Azure service offering?
> Media encoding and streaming.

Which Service Bus offering enables connected messaging across complex networks?
> Service Bus Relay.
