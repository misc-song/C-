import urllib.request
import urllib.parse
import json
# htt = urllib.request.urlopen("www.youdao.com")

url = "http://fanyi.youdao.com/translate?smartresult=dict&smartresult=rule&smartresult=ugc&sessionFrom=dict2.top"

while(True):
    print("��������Ҫ���������:(����Q�س���������)")
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
        print("����Ľ����:%s" % (target['translateResult'][0][0]['tgt']))
        #continue
