##### �������������
> �ر���Http֪ʶ
1. ÿ��ajax���󶼻�������ͷЯ�� Origin �����ü�����������������Ǹ��ط����������ֹajax�����޸�Origin����ͷ��
2. �����Ĭ���ǽ�ֹ��������ģ� ������ָ ����Э�飬�������˿�  ��������һ����һ�¶��ᱻ������ܾ���

###### �������
1. ����˷���ʱ(���Ը���origin����У�飬�����ٷ���)���ڷ���ͷ��� 
```
//��ʾ�ɽ��ܵ�����Դ
Access-Control-Allow-Origin:http://172.20.0.206    / *
//���Խ�cookies д�뵽��������߷��͵������;  ��OriginΪ*ʱ������ʧЧ
Access-Control-Allow-Credentials:true
```
2. jsonp
```
����˷��ط���callback('data');
�����ʹ�� script ��ǩ������jq ��jsonp��ʽ
```
[����](https://www.jianshu.com/p/89a377c52b48)
[MDN](https://developer.mozilla.org/zh-CN/docs/Web/HTTP/Access_control_CORS)