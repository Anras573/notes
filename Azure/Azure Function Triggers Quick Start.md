# Azure Function Triggers Quick Start

## Content
1. Manual Triggers and Azure Queue Storage Triggers
2. Blob Triggers and Timer Triggers
3. HTTP Triggers
4. Webhook Triggers
5. Service Bus Triggers and Event Hub Triggers
6. Learning Check

## Manual Triggers and Azure Queue Storage Triggers

## Blob Triggers and Timer Triggers

## HTTP Triggers

## Webhook Triggers

## Service Bus Triggers and Event Hub Triggers

## Learning Check
How do you reference the pre-supplied Json.NET assembly?
> #r "Newtonsoft.Json"

Which of these is NOT required when configuring a queue trigger?
> File path

When configuring a blob trigger, how do you configure the path to retrieve the name of the blob as a function parameter?
> greeting-requests/{name}

How can you access the next scheduled execution time in a timer trigger?
> myTimer.ScheduleStatus.Next

When using an HTTP trigger, you can limit the trigger to specific HTTP verbs.
> True

What query string parameter do clients use to specify an authorization key when calling an HTTP function?
> code

When creating a GitHub webhook trigger, what additional piece of information do you configure? 
> GitHub secret

To create a webhook trigger that integrates with GitHub, you use a Generic JSON webhook. 
> False

When configuring an Event Hub trigger, in addition to event parameter name, Event Hub consumer group, and Event Hub connection, what additional piece of configuration information do you have to supply?
> Event Hub name

When working with Service Bus triggers, what type can you use to get additional message metadata?
> BrokeredMessage