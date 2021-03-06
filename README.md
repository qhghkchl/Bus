# Bus Reservation System : 버스 예매 프로그램

# 개요

- 버스 좌석을 예매하고 관리하는 폼을 제공하는 좌석 예매 및 관리 기능 중 일부를 C# .NET Framework 및 EntityFramework를 이용해 구현하였다.

# 개발 기간

- 2020년 11월 23일 ~ 2020년 11월 29일

# 기능 목록

## 고객용 프로그램

### 1. 회원 가입

<img src="./images/회원가입.png" width="45%">

- 고객 정보를 입력하고 회원가입 버튼을 누르면 정보가 입력되었는지 확인하고 DB에 저장 후 로그인 창으로 넘어간다.

### 2. 로그인
<div>
<img src="./images/로그인.png" width="45%">
</div>
<div>
<img src="./images/로그인완료.PNG" width="45%">
</div>
- 아이디와 비밀번호를 입력하여 로그인하고 메뉴 폼이 나온다.

### 3. 메뉴
<div>
<img src="./images/메뉴화면.PNG" width="45%">
</div>

- 원하는 메뉴를 선택하면 이동한다. 

### 4. 예매
<div>
<img src="./images/예매.png" width="45%">
</div>

- 출발지, 도착지, 날짜, 시간, 등급을 선택 후 조회를 누르면 좌석 선택 폼으로 이동한다.  

### 5. 좌석 선택 폼

<div>
</div>

- 선택 가능한 좌석을 선택 후 다음 버튼을 클릭하여 확인 및 결제 폼으로 이동한다.
- 예약한 좌석은 데이터베이스에 저장된다.

## 직원용 프로그램

### 1. 직원 로그인

<div>
<img src="./images/직원로그인.png" width="45%">
</div>

- 아이디 admin, 비밀번호: 3512 를 입력하고 로그인 버튼을 누르면 직원용 관리 폼이 나온다.

### 2. 버스 운행 관리

<div>
<img src="./images/직원관리폼_운행.png" width="45%">
</div>

- 버스의 출발지, 도착지, 날짜, 시간, 버스타입을 추가하면 연동된 DB 테이블로 추가된다.

### 3. 예매 관리

<div>
<img src="./images/직원관리폼_예약.PNG" width="45%">
</div>
<div>
</div>

- 고객이 예매한 좌석의 확인 및 취소가 가능하다.

### 4. 월별 매출액 관리

<div>
</div>
<div>
</div>

- 버스 노선별 월별 매출액을 확인 할 수 있다.
- 버스 등급별 월별 매출액을 확인 할 수 있다.

### 5. 고객 정보 관리

<div>
</div>

- 선택된 고객의 정보 수정 및 삭제가 가능하다.



# 관리 항목

### 1. 고객 정보

- 버스를 예매한 고객의 정보를 확인할 수 있다. 또한, 고객 정보의 수정 및 삭제가 가능하다.

### 2. 버스 운행 정보

- 버스 운행 정보를 확인할 수 있다. 
- 버스 운행을 추가할 수 있다. 

### 3. 좌석 예매 관리

- 버스 별로 예매된 좌석을 확인할 수 있다.

# 사용 기술

## 언어

- C# 3.0+

## 프레임워크

- .Net FrameWork 4.8
- EntityFrameWork 6.2
- Winform

## 데이터베이스

* MSSQL Server 2019

## 기타 개발환경

- Windows 10
- Microsoft Visual Studio Community 2019 v16.8
- Microsoft SQL Server Management Studio v18.6

# 데이터베이스 스키마

![db](./images/DB.PNG)



# 순서도

## 1. 고객용 프로그램

![고객용 다이어그램](./images/고객용다이어그램.png)

## 2. 직원용 프로그램

![직원용 다이어그램](./images/직원용다이어그램.png)

# Point of Interest

# github의 경로 설정을 통일하지 못하여 충돌이 생긴 문제

## 증상
- github 복제가 되질 않음.

## 원인
- 경로 설정을 각각 다르게 설정하였다. 

## 결과
- 경로를 모두 똑같이 설정하여 복제하니 충돌 문제가 사라졌다.

---

# DB Seat테이블에 데이터 입력 오류가 발생하는 문제 

## 증상
- Seat테이블에 데이터를 입력하면, 에러가 발생

## 원인
- Operation에 입력되어 있는 OperationId를 사용하지 않아 발생한 문제

## 결과
- Operation 테이블의 입력되어 있는 OperationId 사용하였더니 Seat 테이블 데이터 입력에 문제가 발생하지 않았다.


---


# 로그인 후 다시 로그인 메세지가 뜨는 문제 

## 증상
- 회원가입한 고객이 로그인을 하였는데 다시 로그인 메세지가 뜨며 창이 닫히는 문제 
<div>
<img src="./images/문제4-1.png" width="45%">
</div>
<div>
<img src="./images/문제4-2.png" width="45%">
</div>


## 결과
- if문으로 중복된 코드가 있어서 제거하니 로그인 완료 후 예매 폼으로 이동함.
<div>
<img src="./images/문제4-1.png" width="45%">
</div>
<div>
<img src="./images/예매.png" width="45%">
</div>

---


# 회원가입 후 데이터베이스에 값이 저장되지 않는 문제 

## 증상
- 회원가입을 하고 난 뒤에 데이터베이스에 값이 저장되지 않아 로그인을 할 수 없는 문제


## 결과
- Customer user = Dao.Customer.GetByName(txtLoginId.Text); 부분에서 breakpoint debugging 한 결과, txtLoginId.Text는 계속 null값으로 보여줬다. 
- 테이블에 저장하고자 하는 값을 지정해야함으로 userval이라는 함수를 선언하고 이는 customer테이블에 속성을 갖게함으로써 해결했다.

<div>
<img src="./images/회원가입오류.png" width="45%">
</div>
