#生成十个密码，密码长度为8位，只包含字母和数字
import random
s='abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789'
for i in range(1,11):
    st=str()
    for j in range(1,9):
        st+=s[random.randint(0,len(s)-1)]
    print(st)