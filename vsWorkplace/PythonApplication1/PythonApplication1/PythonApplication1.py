import urllib.request

row = "http://placekitten.com"
i = 500
j = 500
while(i < 1920):
    while((j < 1920)):
        newstr = row + "/" + str(i) + "/" + str(j)
        res = urllib.request.Request(newstr)
        response = urllib.request.urlopen(res)

        cat_img = response.read()

        with open(("cat_"+str(i)+str(j)+".jpg"), 'wb') as f:
            f.write(cat_img)
        i = i + 10
    j = j + 10