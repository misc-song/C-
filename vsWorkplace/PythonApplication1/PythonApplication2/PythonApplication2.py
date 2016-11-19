import urllib.request
import urllib.parse
import json
# htt = urllib.request.urlopen("www.youdao.com")

url = "http://fanyi.youdao.com/translate?smartresult=dict&smartresult=rule&smartresult=ugc&sessionFrom=dict2.top"

while(True):
    print("请输入你要翻译的内容:(输入Q回车结束程序)")
    content = input()
    if(content=="Q"):
        break
    else:
        data = {}
        data['type'] = 'AUTO'
        data['i'] = content
        data['doctype'] = 'json'
        data['xmlVersion'] = '1.8'
        data['keyfrom'] = 'fanyi.web'
        data['ue'] = 'UTF-8'
        data['action'] = 'FY_BY_CLICKBUTTON'
        data['typoResult'] = 'true'
        data = urllib.parse.urlencode(data).encode('utf-8')

        response = urllib.request.urlopen(url, data)
        html = response.read().decode('utf-8')
        target = json.loads(html)
        print("翻译的结果是:%s" % (target['translateResult'][0][0]['tgt']))
        #continue
