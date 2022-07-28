As a network engineer in telecomm, a lot of IP need to be calculated day by day for design or configuration.

And using some offline or online tools, it requires to fill address or mask one by one then click submit button to get the result.

Then this software is coded with C# based on the project [ipnetworks](https://github.com/lduchosal/ipnetwork) which can be used as CLI, and then IPCalculate is  a GUI tool running on Windows with .NET 4.7.2+.


## 1. Calculate the available host address:
This is the main function, and shown once open the software, it can calculate IPv4 or IPv6 range but shown with different result. The result can be copied out.

![ip calculate][https://github.com/MinpuKang/IPCalculate/blob/main/images/1.gif]

## 2. More Functions
[ipnetworks](https://github.com/lduchosal/ipnetwork) has some more functions which also supported by IPCalculate, click "More" can open "More functions" form.

![Open more function][./image/2.1.gif]

### 2.1 IP subnetted
This is to subnet a network to more sub-network with a new netmask lenght.

![IPv4 subnetted][./image/2.2.1.gif]

![IPv6 subnetted][./image/2.2.2.gif]

Note: to reduce the resource load, if the subnet cutted is more than 10, it only shows the top ten.

### 2.2 IP contains or IP overlap
It uses to check if a IP address or IP range contained by another one or overlapped.

![IP Contain or overlap][./image/2.3.gif]

### 2.3 IP merge
It uses to merge two IP range to one with some rule followed:
- 1. They have the same netmask lenght
- 2. After merged, the new netwwork can only be subnetted into the original ranges.

![IP Contain or overlap][./image/2.4.gif]


## 3. About and Help 
Click "About" in main form can only About and Help.

![About][./image/3.1.gif]

About describes the version and author, and each version introduction.

![About][./image/3.2.gif]

It can get help with following the Wechat Official Account to leave a message.

