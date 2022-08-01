As a network engineer in telecomm, a lot of IP need to be calculated day by day for design or configuration.

And using some offline or online tools, it requires to fill address or mask one by one then click submit button to get the result.

Then this software is coded with C# based on the project [ipnetworks](https://github.com/lduchosal/ipnetwork) which can be used as CLI, and then IPCalculate is  a GUI tool running on Windows with .NET 4.7.2+.


## 1. Calculate the available host address:
This is the main function, and shown once open the software, it can calculate IPv4 or IPv6 range but shown with different result. The result can be copied out.

![ip calculate][1]

## 2. More Functions
[ipnetworks](https://github.com/lduchosal/ipnetwork) has some more functions which also supported by IPCalculate, click "More" can open "More functions" form.

![Open more function][2]

### 2.1 IP subnetted
This is to subnet a network to more sub-network with a new netmask lenght.

![IPv4 subnetted][3]

![IPv6 subnetted][4]

Note: to reduce the resource load, if the subnet cutted is more than 10, it only shows the top ten.

### 2.2 IP contains or IP overlap
It uses to check if a IP address or IP range contained by another one or overlapped.

![IP Contain or overlap][5]

### 2.3 IP merge
It uses to merge two IP range to one with some rule followed:
- 1. They have the same netmask lenght
- 2. After merged, the new netwwork can only be subnetted into the original ranges.

![IP Contain or overlap][6]


## 3. About and Help 
Click "About" in main form can only About and Help.

![Open About][7]

About describes the version and author, and each version introduction.

![About][8]

It can get help with following the Wechat Official Account [qiheyehk](https://weixin.sogou.com/weixin?type=1&s_from=input&query=qiheyehk&ie=utf8&_sug_=n&_sug_type_=) to leave a message.

## 4. Get the software

One exe package can be downloaded with link [https://pan.baidu.com/s/1eCNcN5rCACe_XRF9hv87qQ](https://pan.baidu.com/s/1eCNcN5rCACe_XRF9hv87qQ) with extracted code: <font color='red'>k2sf</font>

Or this repository can be cloned, and the exe file is in bin/Debug/IPCalculate.exe.


[1]: https://mmbiz.qpic.cn/mmbiz_gif/QqiaFS6NT0eCYVwibzfT6iaHFN3uphDTFL51McuuMU1wz9dXUZcyjYEzFBKn2AqYchjdbWC1wwva3WVcttpQzd1Yw/0?wx_fmt=gif


[2]: https://mmbiz.qpic.cn/mmbiz_gif/QqiaFS6NT0eCYVwibzfT6iaHFN3uphDTFL5ACgnOLYnpl40YFWDcphaSicvlxrqDV2nibsiboyIBMtLkONxHqWzuDg0Q/0?wx_fmt=gif


[3]: https://mmbiz.qpic.cn/mmbiz_gif/QqiaFS6NT0eCYVwibzfT6iaHFN3uphDTFL5BZ9ViaCCauKfLPvIRlCnibjicQygueS1nhrsCjNNlVjrLdbhlHFJ3l7fw/0?wx_fmt=gif


[4]: https://mmbiz.qpic.cn/mmbiz_gif/QqiaFS6NT0eCYVwibzfT6iaHFN3uphDTFL5UERY44XA72Qf9LibVp1E6pZUuudbKyTH5G9VOFQo3lgia6OPnLxicaltw/0?wx_fmt=gif


[5]: https://mmbiz.qpic.cn/mmbiz_gif/QqiaFS6NT0eCYVwibzfT6iaHFN3uphDTFL5WCKWeyLRCJVGKCycFsnM4hFQiaYxVN8v2qdEnBoaibUia6ial6Q11dFDRQ/0?wx_fmt=gif


[6]: https://mmbiz.qpic.cn/mmbiz_gif/QqiaFS6NT0eCYVwibzfT6iaHFN3uphDTFL5yK20gEibI0IiaHib2lDO5wEpjfibFWMQRT01Sm2SE2nALSwCtjdT0U0ibiaQ/0?wx_fmt=gif


[7]: https://mmbiz.qpic.cn/mmbiz_gif/QqiaFS6NT0eCYVwibzfT6iaHFN3uphDTFL5BBy7HbcxpfLTetYLUiakJhpbLtU3b8ibGI0UXz7yhJpCGnmibgicQBIeJg/0?wx_fmt=gif


[8]: https://mmbiz.qpic.cn/mmbiz_gif/QqiaFS6NT0eCYVwibzfT6iaHFN3uphDTFL5RwgN2bR9muwk1sJCEMmnJIU48nS2ia7HzF5icUNYiayfmgte27icgswKzg/0?wx_fmt=gif


