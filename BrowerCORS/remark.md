##### 浏览器跨域问题
> 必备的Http知识
1. 每次ajax请求都会在请求头携带 Origin 键，该键表明这个请求来自那个地方；浏览器禁止ajax操作修改Origin请求头；
2. 浏览器默认是禁止跨域请求的； 跨域是指 请求协议，域名，端口  三个任意一个不一致都会被浏览器拒绝；

###### 解决方法
1. 服务端返回时(可以根据origin来做校验，满足再返回)，在返回头添加 
```
//表示可接受的请求源
Access-Control-Allow-Origin:http://172.20.0.206    / *
//可以将cookies 写入到浏览器或者发送到服务端;  在Origin为*时，设置失效
Access-Control-Allow-Credentials:true
```
2. jsonp
```
服务端返回方法callback('data');
浏览器使用 script 标签，或者jq 的jsonp方式
```
[简书](https://www.jianshu.com/p/89a377c52b48)
[MDN](https://developer.mozilla.org/zh-CN/docs/Web/HTTP/Access_control_CORS)