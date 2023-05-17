from tkinter import *

jaji = ['']

def _from_rgb(rgb):
    return "#%02x%02x%02x" % rgb  

def a_add():
    jaji[0] = str("+")
    add_button.config(bg = "yellow")
    sub_button.config(bg = _from_rgb((240, 240, 240)))
    mul_button.config(bg = _from_rgb((240, 240, 240)))
    div_button.config(bg = _from_rgb((240, 240, 240)))
def a_sub():
    jaji[0] = str("-")
    add_button.config(bg = _from_rgb((240, 240, 240)))
    sub_button.config(bg = "yellow")
    mul_button.config(bg = _from_rgb((240, 240, 240)))
    div_button.config(bg = _from_rgb((240, 240, 240)))
def a_mul():
    jaji[0] = str("*")
    add_button.config(bg = _from_rgb((240, 240, 240)))
    sub_button.config(bg = _from_rgb((240, 240, 240)))
    mul_button.config(bg = "yellow")
    div_button.config(bg = _from_rgb((240, 240, 240)))
def a_div():
    jaji[0] = str("/")
    add_button.config(bg = _from_rgb((240, 240, 240)))
    sub_button.config(bg = _from_rgb((240, 240, 240)))
    mul_button.config(bg = _from_rgb((240, 240, 240)))
    div_button.config(bg = "yellow")

def update():
    rst1=eval(ent1.get()+str("+")+ent2.get())
    rst2=eval(ent1.get()+str("-")+ent2.get())
    rst3=eval(ent1.get()+str("*")+ent2.get())
    rst4=eval(ent1.get()+str("/")+ent2.get())
    
    if jaji[0] == "+" :
        res.delete(0,"end")
        res.insert(0, rst1)
    elif jaji[0] == "-":
        res.delete(0,"end")
        res.insert(0, rst2)
    elif jaji[0] == "*":
        res.delete(0,"end")
        res.insert(0, rst3)
    elif jaji[0] == "/":
        res.delete(0,"end")
        res.insert(0, rst4)
        
win = Tk()
total = 0
win.geometry('800x400') 
win.title("계산기 프로그램")

res=Entry(win,font=("",20),width=20,bg="white",justify="center")
ent1=Entry(win,width=20,bg="yellow",font=("",20),justify="center")
ent1.place(x=150,y=50)
ent2=Entry(win,width=20,font=("",20),justify="center",bg="yellow")
ent2.place(x=150,y=150)

lb = Label(win, text="계산기 프로그램",font=("",20),bg="white") 
lb1 = Label(win, text="A값",width=5,font=("",20),bg="white")
lb2 = Label(win, text="B값",width=5,font=("",20),bg="white")
lb4 = Label(win, text="연산자",width=5,font=("",20),bg="white")

lb.place(x=200,y=0)
lb1.place(x=50,y=50)
lb2.place(x=50,y=150)
lb4.place(x=50,y=100)
res.place(x=150,y=200)

add_button = Button(win, text="+",width=7,bg="yellow",font=("",12),justify="center", command=a_add)
sub_button = Button(win, text="-",width=7,font=("",12),justify="center", command=a_sub)
mul_button= Button(win, text="*",width=7, font=("",12),justify="center",command=a_mul)
div_button = Button(win, text="/",width=7, font=("",12),justify="center",command=a_div)

add_button.place(x=150,y=100)
sub_button.place(x=230,y=100)
mul_button.place(x=310,y=100)
div_button.place(x=390,y=100)

res_button = Button(win, text="결과(=)",width=5,font=("",20),bg="yellow",command=update)
res_button.place(x=50,y=200)

win.mainloop()