# 다 같이 놀자, 동물 친구들!

## 프로젝트 소개
연극 전공 4명과 소프트웨어 전공 4명의 협력으로 장기 치료중인 환아들을 위하여 특별한 경험을 선사하는 것을 목표로 시작

각자의 전문 지식을 활용해 어린이극을 제작하고 병원에서 공연하며, 해당 어린이극의 내용과 캐릭터, 스토리 라인을 바탕으로 게임을 개발하는 프로젝트

## 프로젝트 팀 구성

**개발팀**

- 정나영 : Stage 1 호랑이 게임
- 김상협 : Stage 2 토끼 게임 & 점수판
- 이정현 : 기획, 개발 총괄 팀장 & Stage 3 고양이 게임
- 정지연 : UI & UX Designer

**기획팀**

- 이혜승 : 기획 팀장
- 이단비 : 캐릭터 디자인
- 김민재 : 효과음 & BGM
- 송유빈 : 연계 스토리 라인

## Stage 1 : 호랑이 게임
- 담당자 : 정나영 Nayoung Jeong

**발표 이후 진행 상황**

- 코드 리팩토링 완료
- Fever Time 로직 구현 완성
- 상황에 따른 BGM 전환 및 사운드 효과 추가
- Fever Time, 틀린 동물 선택 시 UI 효과 부여 (빨간 필터)
- 게임 시작 시 UI와 일시 정지 후 재시작 시 Text UI 구분

**추후 수정사항**

  - 호랑이  터치 시 이미지 바꾸는 로직 enhance
  - 진동 효과 적용
  - 모드 추가

**게임 설명**

- Step 1 : 모드 선택
    - 더 쉽게 (easy mode) - 호랑이, 다람쥐, 강아지 중에 랜덤! 한 번 Swap 할 때마다 3마리의 호랑이를 찾아요. Swap 주기는 3초(base)에서 -0.1초 씩! 호랑이를 찾을 때마다 10점씩 점수를 얻어요.
    - 더 어렵게 (hard mode) - 호랑이, 다람쥐, 강아지, 토끼, 원숭이, 고양이 중에 랜덤! 총 2마리의 호랑이를 찾아요. Swap 주기는  3초(base)에서 -0.2초 씩! 호랑이를 찾을 때마다 15점씩 점수를 얻어요.
    
    *Swap:게임 내에서 카드들이 재배치되는 상황
    
- Step 2 : In-Game
    - <Fever Time!>
        - 발생 트리거 : easy mode는 **200점**, hard mode는 **300점** 주기로 발생하는 보너스 이벤트예요.
        - 특징 : Fever Time은 5초! 5초동안 호랑이 9마리가 나타나고, 터치할 때마다 easy는 20점, hard는 25점을 줘요. (보너스 점수)
        - Fever Time동안 얻은 점수는 주기에 영향을 주지 않아요.
    - <Volume Up!>      
        - BGM을 들으며 하면 더 재밌어요.
        - Fever Time에는 집중도를 높이기 위한 피치 높은 BGM이!
        - 틀렸을 때는 뿝- 하는 효과음이!
        - 게임이 끝나면 또 다른 BGM이 나와요.
- Step 3 : Game Over
    - Life는 총 3개! Life가 0이 되는 순간 게임이 끝나요.
    - 주의) Fever Time 5초 이후 화면이 바로 전환돼요. 남은 시간을 잘 보지 않으면 Fever Time 종료와 동시에 게임이 끝날 수 있어요.
- Step 4 : To pause the Game
    - 우측 상단의 버튼을 터치하면 게임을 일시정지 하고 게임을 지속할지, 종료할지 선택할 수 있어요. 잘못 들어간 게임을 끝까지 지킬 필요가 없어요!
- How to Enjoy the Game?
    - https://playwithanimals.netlify.app/
    - APK 파일뿐 아니라 WebGL 배포를 해두었어요. 위 링크에 접속하시면 게임을 즐길 수 있어요 :)

- 사용한 에셋
    - Party Pack [ Sound ] : free($0)
        - 틀린 동물 선택 (=Life 감소) 시 쓸 효과음 Import
    - 디자인 및 BGM 출처 (에셋 사용 X)
        - 캐릭터 디자인 -  국민대학교 연극 전공 김인준 교수님이 만들어주셨어요.
        - 배경 디자인 및 BGM - AI 서비스를 활용하여 제작했어요.
        - 아이콘 디자인 : 호랑이 게임 담당자(정나영)가 직접 디자인 툴을 활용하여 제작했어요.

## Stage 2 : 토끼 게임

- 담당자 : 김상협 (Stage 2 토끼게임 & 점수판)
  
**토끼게임**

- 게임에 진입하면 배경음악과 함께 3초의 카운트다운 진행
- 화면을 터치하면 화면 중앙의 토끼가 점프
- 줄넘기 줄의 속도는 완전 랜덤값으로 0.5~1.2 사이의 재생속도를 1.5초마다 바꿔가면서 줄이 돌게 된다.
- 줄에 걸리면 게임 종료! 게임종료 UI가 출력되면서 다시 시작할지 메인 화면으로 넘어갈지 선택할 수 있다.

**점수판**

- ScoreManager가 게임이 시작되면 생성된다.
- ScoreManager는 각 게임에서 호출하여 최고 점수를 얻어올 수 있다.
- 얻어온 최고점수는 각 게임에서 불러와서 화면에 출력하는 방식으로 활용할 수 있다.
- 최고점수 기록은 Playerprefs 클래스를 활용하여 저장했다.

**에셋**
- 디자인 출처 (에셋 사용 X)
  - 캐릭터 디자인 - 기획 팀원의 디자인
  - 배경 디자인 - AI 서비스를 활용하여 제작했다.
  - BGM - 무료 BGM 배포 사이트를 이용
 
## Stage 3 : 고양이 게임

- 담당자 : 이정현 (Stage 3 고양이게임 & 기획, 개발 총괄 팀장)

**고양이 게임**

- Step 1 : CountDown
    - 3,2,1 게임 시작! 카운트 동안에는 터치도 일시정지도 되지 않고 게임을 시작하기 전 마음의 준비를 하는 시간입니다!
    
- Step 2 : Game Start!!!
    - <기록 갱신!>
        - 화면의 중앙을 기준으로 클릭을 유지하면 캐릭터를 움직여서 떨어지는 장난감을 먹을 수 있습니다.
        - 작은 장난감은 50점, 중간 장난감은 100점, 큰 장난감은 150점을 줍니다!
        - 랜덤 랜덤 랜덤 : 0.4초 ~ 0.7초의 랜덤한 주기로 랜덤한 장난감이 랜덤한 위치에서 마구마구 떨어집니다!
        - 본인의 기록을 깨거나 다른 친구와 대결하는 것도 재미있을 것 같아요~
    - <Volume Up!>
        - BGM을 들으며 하면 더 재밌어요.
        - 발랄하고 신나는 BGM이 흘러나옵니다~
        - 장난감을 먹으면 성취감이 드는 효과음이 뿅!

- Step 3 : 종료 기준
    - 30초의 제한시간이 다 지나면 게임 종료 UI가 출력되면서 종료됩니다.
    - PS. 이번 플레이가 조금 아쉽다면 바로 다시하기를 통해서 한 번 더 즐길 수도 있어요!
    - 
- Step 4 : 급한 일이 있으면 어떡하나요!
    - 우측 상단의 버튼을 터치하면 게임을 일시정지 하고 게임을 지속할지, 종료할지 선택할 수 있어요. 잘못 들어간 게임을 끝까지 지킬 필요가 없어요!

**에셋**

- 디자인 출처 (에셋 사용 X)
  - 캐릭터 디자인 - 기획 팀원의 디자인
  - 배경 디자인 - 기획 팀원의 디자인
  - BGM - AI 서비스를 활용하여 제작했습니다.

# UI Documentation
- 담당자 : 정지연

## 주요 UI 기능

### 1. **UI ScriptableObjects**

- **역할**: 플레이어가 플레이할 캐릭터의 정보를 저장합니다.
- **사용 방법**: 캐릭터 데이터를 쉽게 수정하거나 확장 가능하도록 설계되었습니다. 이를 통해 다양한 캐릭터 설정 및 불러오기를 지원합니다.

---

### 2. **UI 깨짐 방지 시스템**

### **ImageScaler.cs**

- **기능**: 게임 내 모든 이미지의 종횡비를 완벽히 유지합니다.
- **작동 방식**: 동적 크기 조정을 통해 UI가 비율에 맞게 조정됩니다.

### **SafeArea.cs**

- **기능**: 디바이스의 안전 영역(Safe Area)을 감지하고 UI 및 게임 오브젝트가 해당 영역 내에서 배치되도록 보장합니다.
- **장점**: 화면 상단 노치나 하단의 시스템 바에 의해 UI가 가려지지 않게 합니다.

---

### 3. **메인 화면 관리 시스템**

### **MainMenuManager.cs**

- **역할**: 메인 화면을 제어하며, 다른 씬으로의 이동을 처리합니다.
- **기능**:
    - 버튼 클릭 이벤트를 통해 게임 시작, 설정, 종료 등을 제어.
    - 주요 씬 간의 전환 로직을 포함.

### **ModalManager.cs**

- **역할**: 메인 화면의 모달 팝업들을 관리합니다.
- **특징**:
    - **싱글톤 패턴**을 사용하여 어디서든 모달 팝업 호출 가능.
    - 다수의 팝업을 효율적으로 제어(열기/닫기)합니다.

### **LoadingSceneManager.cs**

- **역할**: 비동기 로딩을 통해 씬 전환 시 발생할 수 있는 끊김 현상을 방지합니다.
- **기능**:
    - 로딩 화면을 표시하며, 씬이 준비될 때까지 자연스러운 전환을 제공합니다.

---

## 유의사항

1. **스크립트 종속성**
    - `MainMenuManager.cs`는 다른 씬 관리 스크립트와 상호작용하므로 제거나 수정 시 주의가 필요합니다.
2. **해상도 테스트**
    - UI 깨짐 방지 기능은 다양한 해상도에서 테스트되었으나, 새로운 기기 추가 시 추가 테스트를 권장합니다.



